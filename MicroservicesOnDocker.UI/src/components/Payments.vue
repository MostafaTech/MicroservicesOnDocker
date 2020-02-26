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
export default {
    data: () => ({
        list: []
    }),
    mounted() {
        this.$incomeService.get('/payments').then(r => {
            this.list = r.data;
        })
    }
}
</script>