<template>
  <div>{{weather}}</div>
</template>

<script>
  export default {
    name: 'Comptest',
    data() {
      return {
        weather: null
      }
    },
    mounted() {
      this.axios
        .get("https://localhost:44329/weatherforecast")
        .then((response) => {
          this.weather = response.data
        }).catch((error) => {
          console.log(error)
        });
    }
  }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  h1, h2 {
    font-weight: normal;
  }

  ul {
    list-style-type: none;
    padding: 0;
  }

  li {
    display: inline-block;
    margin: 0 10px;
  }

  a {
    color: #42b983;
  }
</style>
