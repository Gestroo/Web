<template>
    <div class='topbar-div dark'>
        <div class='left-div'>
            <p class ='header-text text'>Statistics</p>
            <div class='search-block'>
                <img src="../assets/search.svg" class="search-image" alt="">
                <input type='text' class="search-input dark text" placeholder="Search">
            </div>
            <img src="../assets/notification.svg" class="notification" alt="">
        </div>
        <div class= 'profile-div'>
            <p class="text profile-text">Dmitriy</p>
            <img src="../assets/Dima.jpg" class="profile-pic" alt="">
        </div>
    </div>
</template>

<script lang="ts">
import Vue from 'vue';

export default Vue.extend({
  name: 'Topbar',
});
</script>

<style scoped>
.topbar-div {
    justify-content: space-between;
  display:flex;
    width:95%;
    height:7%;
    margin-left: 5%;
}
.dark{
background-color: #212427 ;
color: #212427;
}
.header-text{
    font-size: 24px;

}
.search-block{
    margin-left: 5%;
    width:30%;
    outline: hidden;
}
.search-input{
    width: 70%;
    margin-top:24px;
    display:block;
    padding : 5px 25px;
    border: 1px solid gray;
    border-radius:8px;
}
.notification{
    margin-top:27px;
    margin-left:12%;
width: 20px;
height:20px;
}
.search-image{
    z-index: 5;
margin-top:32px;
margin-left:7px;
position:absolute
}
.left-div{
    display: flex;
    margin-left: 3%;
    }
.profile-div{
display: flex;
margin:auto 3% ;

    }
.profile-pic{
    margin:auto;
    width:50px;
    height:50px;
    border-radius:35px;
    margin-left:1%;
        }
.profile-text{
    margin-right: 10px;
    font-size:20px;
}
.text{
    color: #fff
}
</style>
