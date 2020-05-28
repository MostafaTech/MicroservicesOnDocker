import Vue from 'vue'
import Vuex from 'vuex'

// http
import { CreateHttpService } from './services/ajax'
const schoolService = CreateHttpService('school');
const incomeService = CreateHttpService('income');

Vue.use(Vuex)
const store = new Vuex.Store({
    state: {
        courses: [],
        students: [],
        payments: [],
    },

    getters: {
        courses: (state) => state.courses,
        students: (state) => state.students,
        payments: (state) => state.payments,
    },

    actions: {
        loadCourses({ commit }) {
            schoolService.get('/courses').then(r => {
                commit('setCourses', r.data);
            })
        },
        loadStudents({ commit }) {
            schoolService.get('/students').then(r => {
                commit('setStudents', r.data);
            })
        },
        loadPayments({ commit }) {
            incomeService.get('/payments').then(r => {
                commit('setPayments', r.data);
            })
        },
        addSampleData({ dispatch }) {
            schoolService.post('/commands/addSampleData').then(r => {
                dispatch('loadCourses');
                dispatch('loadStudents');
                dispatch('loadPayments');
            })
        }
    },

    mutations: {
        setCourses(state, data) {
            state.courses = data;
        },
        setStudents(state, data) {
            state.students = data;
        },
        setPayments(state, data) {
            state.payments = data;
        },
    },
})

export default store;