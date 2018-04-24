$(document).ready(function() {
  var offset = $("input").offset();
  $("#a6").css("visibility", "hidden");

  $("#a4").click(function() {
    if($("input").css("top") == "18px") {
      $("input").animate({
        top:"94.5px",
        zIndex:"1"
      }, 500);
      $("#topsearch").css("visibility", "hidden");
      $("#a6").css("visibility", "initial");
      $("#a6").animate({
        top:"102.5px",
        color:"#000000"
      }, 500);
    }
    else {
      $("input").animate({
        top:"18px"
      }, 500);
      $("input").css("z-index", "-1");
      $("#a6").animate({
        top:"28px",
        visibility:"hidden",
        color:"#FFFFFF"
      }, 500);
    }
  });

  $("#a33").click(function() {
    if($("#more").css("visibility") == "hidden") {
      $("#more").css("visibility", "initial");
    }
    else {
      $("#more").css("visibility", "hidden");
    }
  });

  $("#cpa1, #cardheader1").mouseenter(function() {
    $("#cardheader1").css("background-color", "#DC143C");
  });

  $("#cpa1, #cardheader1").mouseleave(function() {
    $("#cardheader1").css("background-color", "#000000");
  });

  $("#cpa2, #cardheader2").mouseenter(function() {
    $("#cardheader2").css("background-color", "#DC143C");
  });

  $("#cpa2, #cardheader2").mouseleave(function() {
    $("#cardheader2").css("background-color", "#000000");
  });

  $("#cpa3, #cardheader3").mouseenter(function() {
    $("#cardheader3").css("background-color", "#DC143C");
  });

  $("#cpa3, #cardheader3").mouseleave(function() {
    $("#cardheader3").css("background-color", "#000000");
  });

  $("#cpa4, #cardheader4").mouseenter(function() {
    $("#cardheader4").css("background-color", "#DC143C");
  });

  $("#cpa4, #cardheader4").mouseleave(function() {
    $("#cardheader4").css("background-color", "#000000");
  });

  $("#cpa5, #cardheader5").mouseenter(function() {
    $("#cardheader5").css("background-color", "#DC143C");
  });

  $("#cpa5, #cardheader5").mouseleave(function() {
    $("#cardheader5").css("background-color", "#000000");
  });

  $("#cpa6, #cardheader6").mouseenter(function() {
    $("#cardheader6").css("background-color", "#DC143C");
  });

  $("#cpa6, #cardheader6").mouseleave(function() {
    $("#cardheader6").css("background-color", "#000000");
  });

  $(".sidepic1, .sidehead1").mouseenter(function() {
    $(".sidepic1").css("background-color", "#EEEEEE");
  });

  $(".sidepic1, .sidehead1").mouseleave(function() {
    $(".sidepic1").css("background-color", "initial");
  });

  $(".sidepic2, .sidehead2").mouseenter(function() {
    $(".sidepic2").css("background-color", "#EEEEEE");
  });

  $(".sidepic2, .sidehead2").mouseleave(function() {
    $(".sidepic2").css("background-color", "initial");
  });

  $(".sidepic3, .sidehead3").mouseenter(function() {
    $(".sidepic3").css("background-color", "#EEEEEE");
  });

  $(".sidepic3, .sidehead3").mouseleave(function() {
    $(".sidepic3").css("background-color", "initial");
  });
});
