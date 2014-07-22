
$(document).ready(function () {   
    $('#ajax li').on('click', function () {
        var url = $(this).data('url');
        $.get(url, function (data) {
            $('.mainAbout').html(data);
        });
        $('#ajax li').removeClass('active');
        $(this).addClass('active');
    });
    
  });  
   
 

