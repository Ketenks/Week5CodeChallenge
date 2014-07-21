function Confirmation(el) {
   this.el = el;
    //after the DOM is loaded, then execute this code
    $(el).on('click', function () {
        //use a .get request to update the data
        var url = $(el).data('url');
        $.get($(el).data('url'), function (data) {
            $('.mainAbout').html(data);
        });
    });
}



$(document).ready(function () {
var who = new Confirmation($('.wholink'));
var what = new Confirmation($('.whatlink'));
var why = new Confirmation($('.whylink'));
var how = new Confirmation($('.howlink'));
var where = new Confirmation($('.wherelink'));
    
    ////after the DOM is loaded, then execute this code
    //$('.wholink').on('click', function () {
    //    //use a .get request to update the data
    //    var url = $(this).data('url');
    //    $.get($(this).data('url'), function (data) {
    //        $('.mainAbout').html(data);
    //    });
    //});
    ////after the DOM is loaded, then execute this code
    //$('.whatlink').on('click', function () {
    //    //use a .get request to update the data
    //    var url = $(this).data('url');
    //    $.get($(this).data('url'), function (data) {
    //        $('.mainAbout').html(data);
    //    });
    //});
    ////after the DOM is loaded, then execute this code
    //$('.whylink').on('click', function () {
    //    //use a .get request to update the data
    //    var url = $(this).data('url');
    //    $.get($(this).data('url'), function (data) {
    //        $('.mainAbout').html(data);
    //    });
    //});
    ////after the DOM is loaded, then execute this code
    //$('.howlink').on('click', function () {
    //    //use a .get request to update the data
    //    var url = $(this).data('url');
    //    $.get($(this).data('url'), function (data) {
    //        $('.mainAbout').html(data);
    //    });
    //});
    ////after the DOM is loaded, then execute this code
    //$('.wherelink').on('click', function () {
    //    //use a .get request to update the data
    //    var url = $(this).data('url');
    //    $.get($(this).data('url'), function (data) {
    //        $('.mainAbout').html(data);
    //    });
    //});
  });  
   
   // //after the DOM is loaded, then execute this code
   //$('.wherelink').on('click', function () {
   //    //use a .get request to update the data
   //     var url = $(this).data('url');
   //    $.get($(this).data('url'), function (data) {
   //        $('.main').html(data);
   //    });
   //});

