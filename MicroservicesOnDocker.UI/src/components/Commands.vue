<template>
    <div>
        <button type="button" class="btn btn-primary" 
                @click="addSampleData()">Add Sample Data</button>
    </div>
</template>

<script>
    import { mapActions } from 'vuex'
    export default {
        methods: {
            ...mapActions(['addSampleData']),
        }
    }
</script>