/// <binding BeforeBuild='default' />
'use strict';

var gulp = require('gulp'),
    concat = require('gulp-concat'),
    cssmin = require('gulp-cssmin'),
    htmlmin = require('gulp-htmlmin'),
	uglify = require('gulp-uglify-es').default,
    merge = require('merge-stream'),
    del = require('del'),
	sass = require("gulp-sass"),
    bundleconfig = require('./bundleconfig.json'),
    compilerconfig = require('./compilerconfig.json');

const regex = {
    css: /\.css$/,
    html: /\.(html|htm)$/,
    js: /\.js$/,
	scss: /\.scss$/,
};

gulp.task("scss", async function () {
	await getCompilerConfigs(regex.scss).map( bundle => {
        return gulp.src(bundle.inputFile, { base: '.' })
            .pipe(concat(bundle.outputFile))
            .pipe(sass())
            .pipe(gulp.dest('.'));
    })
});

gulp.task('min:js', async function () {
    merge(getBundles(regex.js).map(bundle => {
        return gulp.src(bundle.inputFiles, { base: '.' })
            .pipe(concat(bundle.outputFileName))
            .pipe(uglify())
			.on('error', function (err) { console.log(err) })
            .pipe(gulp.dest('.'));
    }))
});

gulp.task('min:css', async function () {
    merge(getBundles(regex.css).map(bundle => {
        return gulp.src(bundle.inputFiles, { base: '.' })
            .pipe(concat(bundle.outputFileName))
            .pipe(cssmin())
            .pipe(gulp.dest('.'));
    }))
});

gulp.task('clean:bundle', () => {
    return del(bundleconfig.map(bundle => bundle.outputFileName));
});

gulp.task('clean:compilerconfig', () => {
    return del(compilerconfig.map(bundle => bundle.outputFile));
});

gulp.task('clean', gulp.series(['clean:bundle', 'clean:compilerconfig']));

gulp.task('min', gulp.series(['clean', 'scss', 'min:js']));

gulp.task('watch', () => {
	
	getBundles(regex.js).forEach(
        bundle => gulp.watch(bundle.inputFiles, gulp.series(["min:js"])));
		
	getBundles(regex.scss).forEach(
        bundle => gulp.watch(bundle.inputFile, gulp.series(["scss"])));

    /*getBundles(regex.css).forEach(
        bundle => gulp.watch(bundle.inputFiles, gulp.series(["min:css"])));*/
});

const getBundles = (regexPattern) => {
    return bundleconfig.filter(bundle => {
        return regexPattern.test(bundle.outputFileName);
    });
};

const getCompilerConfigs = (regexPattern) => {
    return compilerconfig.filter(bundle => {
        return regexPattern.test(bundle.inputFile);
    });
};

gulp.task('default', gulp.series("min"));