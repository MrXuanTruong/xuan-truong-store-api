class OperatorService{
    constructor() {

    }

    loginUser(userInfo) {
        return base_axios.post(API_LOGIN, userInfo);
    }

    getCurrentUser() {
        return base_axios.get(API_GET_CURRENT_USER);
    }

    getById(id) {
        return base_axios.get(`${API_OPERATOR_CRUD}/${id}`);
    }

    save(operator) {
        return base_axios.post(`${API_OPERATOR_CRUD}`, operator);
    }

    update(id, operator) {
        return base_axios.put(`${API_OPERATOR_CRUD}/${id}`, operator);
    }

    delete(id) {
        return base_axios.delete(`${API_OPERATOR_CRUD}/${id}`);
    }
}