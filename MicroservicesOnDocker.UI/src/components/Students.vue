<template>
    <table class="table">
        <tr>
            <th>id</th>
            <th>student</th>
            <th>course</th>
            <th>has paid</th>
        </tr>
        <tr v-for="i in list" :key="i.id">
            <td>{{i.studentId}}</td>
            <td>{{i.studentName}}</td>
            <td>{{i.courseName}}</td>
            <td>{{i.hasPaid ? 'yes' : 'no'}}</td>
        </tr>
    </table>
</template>

<script>
    import { mapGetters, mapActions } from 'vuex'
    export default {
        computed: {
            ...mapGetters({ list: 'students' })
        },
        mounted() {
            this.loadStudents()
        },
        methods: {
            ...mapActions(['loadStudents'])
        }
    }
</script>