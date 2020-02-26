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
export default {
    data: () => ({
        list: []
    }),
    mounted() {
        this.$schoolService.get('/courses').then(r => {
            this.list = r.data;
        })
    }
}
</script>