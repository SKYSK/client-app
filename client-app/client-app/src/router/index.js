import Vue from 'vue'
import Router from 'vue-router'
import HelloWorld from '@/components/HelloWorld'
import Comptest from '@/components/Comptest'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'Comptest',
      component: Comptest
    }
  ]
})
