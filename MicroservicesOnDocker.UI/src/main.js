import Vue from 'vue'
import App from './App.vue'

Vue.config.productionTip = false

// http
import { CreateHttpService } from './services/ajax'
Vue.prototype.$schoolService = CreateHttpService('school');
Vue.prototype.$incomeService = CreateHttpService('income');

new Vue({
  render: h => h(App)
}).$mount('#app')
