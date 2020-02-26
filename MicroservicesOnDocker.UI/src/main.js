import Vue from 'vue'
import App from './App.vue'

Vue.config.productionTip = false

// http
import { CreateHttpService } from './services/ajax'
Vue.prototype.$schoolService = CreateHttpService(process.env.NODE_ENV == 'development' ? 57801 : 5001);
Vue.prototype.$incomeService = CreateHttpService(process.env.NODE_ENV == 'development' ? 57802 : 5002);

new Vue({
  render: h => h(App)
}).$mount('#app')
