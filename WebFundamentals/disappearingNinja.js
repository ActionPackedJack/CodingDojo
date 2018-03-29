$(document).ready(function(){
    $('.ninja').click(function(){
        $(this).slideUp();
    })
    $('button').click(function(){
        $('.ninja').show();
    })
})
