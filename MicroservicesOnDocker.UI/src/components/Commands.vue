<template>
    <div>
        <button type="button" class="btn btn-primary" 
                @click="addSampleData()">Add Sample Data</button>
    </div>
</template>

<script>
    export default {
        data: () => ({
            list: []
        }),
        methods: {
            addSampleData() {
                this.$schoolService.post('/commands/addSampleData').then(r => {
                })
            }
        }
    }
</script>