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
});
