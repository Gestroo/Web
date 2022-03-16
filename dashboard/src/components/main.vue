<template>
  <div class='main-div dark'>
    <div class='topline'>
        <div class='block-border block-color topblock'>
            <div class='jcfx'>
                <p class='header-text'>Friends</p>
                <img src="../assets/dots.svg" alt="">
            </div>
            <div class='jcfx'>
                <p class='header-subtext'>271 people </p>
                <div class="flex">
                    <p class='subtext'>+ 0,7%</p>
                    <img src="../assets/uparrow.svg" class="arrow" alt="">
                </div>
            </div>
        </div>
        <div class='block-border block-color topblock'>
            <div class='jcfx'>
                <p class='header-text'>Unique visitors</p>
                <img src="../assets/dots.svg" alt="">
            </div>
            <div class='jcfx'>
                <p class='header-subtext'>69 people </p>
                <div class="flex">
                    <p class='subtext'>- 1,7%</p>
                    <img src="../assets/downarrow.svg" class="arrow" alt="">
                </div>
            </div>
        </div>
        <div class='block-border block-color topblock'>
            <div class='jcfx'>
                <p class='header-text'>Followers</p>
                <img src="../assets/dots.svg" alt="">
            </div>
            <div class='jcfx'>
                <p class='header-subtext'>288 people </p>
                <div class="flex">
                    <p class='subtext'>+ 1%</p>
                    <img src="../assets/uparrow.svg" class="arrow" alt="">
                </div>
            </div>
        </div>
    </div>
    <div class='midline flex'>
        <div class ='block-border block-color mid-left'>
            <div class='jcfx'>
                <div>
                    <p class='header-text'>Audience reach</p>
                </div>
                <div class='jcfx'>
                        <p class="subtext-mini date-text">31/01/2020 - 06/02/2020 </p>
                    <div class='flex'>
                        <img src="../assets/purplecheck.svg" class='check' alt="">
                        <p class="subtext-mini">Total</p>
                        <img src="../assets/pinkcheck.svg" class="check" alt="">
                        <p class="subtext-mini">Followers</p>
                    </div>
                </div>
            </div>
            <div>
                <img src="../assets/graph.svg" class="graph" alt="">
            </div>
        </div>
        <div class=' block-border block-color mid-right'>
            <p class="header-text solo-text">Reach by device</p>
            <div class="flex">
                <div class="diagram">
                    <img src="../assets/purplediagram.svg" class="subdiagram purpledia"  alt="">
                    <img src="../assets/pinkdiagram.svg" class="subdiagram pinkdia" alt="">
                    <p class="subdiagram high-percent">86%</p>
                    <p class="subdiagram low-percent">14%</p>
                </div>
                <div>
                    <div class="flex">
                        <img src="../assets/pinkbox.svg" alt="">
                        <p class="legend-text">Desktop</p>
                    </div>
                    <div class="flex">
                        <img src="../assets/purplebox.svg" alt="">
                        <p class="legend-text">Mobile views</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="botline">
        <div class="bot-left block-border block-color">
           <div class="jcfx">
               <p class="header-text">Gender/ Age</p>
               <div class="flex">
                   <img src="../assets/pinkbox.svg"  class="check"  alt="">
                   <p class="gender-text ">women</p>
                   <img src="../assets/purplebox.svg" class="check"  alt="">
                   <p class="gender-text ">men</p>
               </div>
            </div>
            <div>
                <img src="../assets/stolbdiagram.svg" class="stolbdia" alt="">
            </div>
        </div>
        <div class="bot-right block-border block-color">
            <div class="jcfx">
                <p class="header-text">Geo</p>
                <div class="flex">
                    <p class= "gender-text">Country</p>
                    <p class="subtext-mini">City</p>
                </div>
            </div>
            <div class="jcfx geo-full">
                <div class="geo-half">
                    <div >
                        <div class="jcfx">
                            <p class="header-subtext">Russia</p>
                            <p class="subtext">94%</p>
                        </div>
                        <img src="../assets/Russia.svg" class="percent-bar" alt="">
                    </div>
                    <div >
                        <div class="jcfx">
                            <p class="header-subtext">Ukraine</p>
                            <p class="subtext">0,20%</p>
                        </div>
                        <img src="../assets/Ukraine.svg" class="percent-bar" alt="">
                    </div>
                    <div >
                        <div class="jcfx">
                            <p class="header-subtext">Mongolia</p>
                            <p class="subtext">0,13%</p>
                        </div>
                        <img src="../assets/Mongolia.svg" class="percent-bar" alt="">
                    </div>
                </div>
               <div class="geo-half">
                    <div >
                        <div class="jcfx">
                            <p class="header-subtext">China</p>
                            <p class="subtext">0,26%</p>
                        </div>
                        <img src="../assets/China.svg" class="percent-bar" alt="">
                    </div>
                    <div >
                        <div class="jcfx">
                            <p class="header-subtext">USA</p>
                            <p class="subtext">0,20%</p>
                        </div>
                        <img src="../assets/Ukraine.svg" class="percent-bar" alt="">
                    </div>
                    <div >
                        <div class="jcfx">
                            <p class="header-subtext">Other</p>
                            <p class="subtext">1,39%</p>
                        </div>
                        <img src="../assets/other.svg" class="percent-bar" alt="">
                    </div>
                </div>
            </div>
        </div>
    </div>
  </div>
</template>

<script lang="ts">
import Vue from 'vue';

export default Vue.extend({
  name: 'Main',
});
</script>

<style scoped>
.main-div{
    max-width: 95%;
    height:93%;
    margin-left: 5%;
    padding: 3%;
}
.midline{
    margin-top:3%;
}
.botline{
    display:flex;
    margin-top:3%;
}
.topline{
    width: 96%;
    display: grid;
      grid-template-columns: repeat(3, 33%);
    gap: 0 40px;
}
.block-color{
background-color: #282c31 ;
}
.geo-full{
    margin-bottom: 5%;
}
.percent-bar{
    height: 10px;
    width:90%;
    margin-bottom:10%;
}
.dark{
background-color: #212427 ;
color: #212427;
}
.arrow{
    margin-left:5px;
}
.flex{
    display:flex;
}
.geo-half{
    width:40%;
}
.header-text{
    color: #fff;
    font-size:24px;
}
.header-subtext{
    color: #fff;
    font-size:20px;
}
.block-border{
    border: 1px solid gray;
    border-radius:13px;
}
.bot-left{
    width:60%;
}
.jcfx{
    justify-content:space-between;
    display:flex;
    margin: 0 5%;
}
.topblock{
    height: 150px;
}
.graph{
    width:100%;
}
.check{
    width:16px;
    margin-left: 10px;
}
.diagram{
    position: relative;
    width: 50%;
    margin-right: 20px;
}
.solo-text{
    margin-left:6%;
}
.mid-left{
    width:65%;
}
.mid-right{
    width: 31%;
    margin-left:5%;
}
.subdiagram{
    position: absolute;
}
.subtext-mini{
  color:#979797;
    font-size:16px;
    margin:auto 0 auto 10px;
}
.date-text{
    margin-right:50px;
}
.purpledia{
    margin-top:20px;
    margin-left:50px;
    width:150px;

}
.pinkdia{
    margin-top:30px;
    margin-left:140px;
    width: 72px;
}
.high-percent{
    color:#fff;
    margin-top:100px;
    margin-left: 80px;
}
.low-percent{
    color:#fff;
    margin-top:60px;
    margin-left:170px;
    font-size: 13px;
}
.legend-text{
    color:#CACACA;
    margin-left:10px;
    font-size:18px;
}
.gender-text{
color:#CACACA;
margin:auto 10px;
font-size: 18px;
}
.stolbdia{
    width:95%;
    height:50%;
}
.bot-right{
    width:35%;
    margin-left:5%;
}
.subtext{
    color:#979797;
    font-size:20px;
}
</style>
