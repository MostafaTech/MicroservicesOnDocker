<template>
  <div id="app">
    <main role="main">
      <HelloWorld />
        <div class="container">
          <div class="row">
            <div class="col-md-6">
              <h2>Students</h2>
              <Students />
              <h2>Courses</h2>
              <Courses />
            </div>
            <div class="col-md-6">
              <h2>Payments</h2>
              <Payments />
            </div>
          </div>
        </div>
    </main>
  </div>
</template>

<script>
// @ is an alias to /src
import HelloWorld from '@/components/HelloWorld.vue'
import Students from '@/components/Students.vue'
import Courses from '@/components/Courses.vue'
import Payments from '@/components/Payments.vue'

export default {
  name: 'Home',
  components: {
    HelloWorld,
    Students,
    Courses,
    Payments
  }
}
</script>