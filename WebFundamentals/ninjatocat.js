
$(document).ready(function(){
    $('img').click(function() {
        $(this).attr('src', $(this).attr('data-alt-src'));
    });
}) 
//HERE IS SOME WORD STUFF