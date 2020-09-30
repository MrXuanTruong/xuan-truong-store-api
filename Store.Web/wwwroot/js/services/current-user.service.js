class CurrentUserService{
    constructor() {

    }

    getCurrentUser() {
        return base_axios.get(API_GET_CURRENT_USER);
    }
}