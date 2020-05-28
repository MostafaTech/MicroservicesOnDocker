<template>
    <table class="table">
        <tr>
            <th>id</th>
            <th>course</th>
        </tr>
        <tr v-for="i in list" :key="i.id">
            <td>{{i.id}}</td>
            <td>{{i.name}}</td>
        </tr>
    </table>
</template>

<script>
    import { mapGetters, mapActions } from 'vuex'
    export default {
        computed: {
            ...mapGetters({ list: 'courses' })
        },
        mounted() {
            this.loadCourses()
        },
        methods: {
            ...mapActions(['loadCourses'])
        }
    }
</script>