<template>
    <table class="table">
        <tr>
            <th>student</th>
            <th>course</th>
            <th>pay amount</th>
        </tr>
        <tr v-for="i in list" :key="i.id">
            <td>{{i.studentName}}</td>
            <td>{{i.courseName}}</td>
            <td>{{i.payAmount}}</td>
        </tr>
    </table>
</template>

<script>
    import { mapGetters, mapActions } from 'vuex'
    export default {
        computed: {
            ...mapGetters({ list: 'payments' })
        },
        mounted() {
            this.loadPayments()
        },
        methods: {
            ...mapActions(['loadPayments'])
        }
    }
</script>