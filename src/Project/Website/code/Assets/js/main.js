// JavaScript Document

$(document).ready(function(){


	var Wwidth = $(window).width();				
if (Wwidth > 768) {
	//alert("Hi");
	
		$("header li.dropdown a").removeClass("dropdown-toggle");
}
if (Wwidth > 992) {
	$('.dropdown-toggle').click(function() { var location = $(this).attr('href'); window.location.href = location; return false; });
}

$('ul.dropdown-menu [data-toggle=dropdown]').on('click', function(event) {
	event.preventDefault(); 
	event.stopPropagation(); 
	$(this).parent().siblings().removeClass('open');
	$(this).parent().addClass('open');
});
$('.btn-back-one, .btn-close').click(function(){
	//alert('Hi');
	$('#navbar .dropdown-menu').removeClass("show");
	$('#header .dropdown-menu .nav-item').removeClass('open');
});
$('.btn-back-two').click(function(){	
	$('#header .dropdown-menu .nav-item').removeClass('open');
});



$('.hamburger, .btn-close, .bg-overlay').click(function(e){ 
		e.stopPropagation();
		$('#navbar').fadeIn().toggleClass('is-open');
		$('.hamburger').toggleClass('is-active');
		$('body').toggleClass('no-scroll');			
		$('#header .dropdown-menu .nav-item').removeClass('open');	
		$('#navbar .dropdown-menu').removeClass("show");		
	});


$(document).on('click', '.dropdown-menu', function (e) {
 e.stopPropagation();
});

$('a.page-scroll').bind('click', function(event) {
		var $anchor = $(this);
		$('html, body').stop().animate({
				scrollTop: $($anchor.attr('href')).offset().top
		}, 800, 'swing');
		event.preventDefault();
  });

$(window).scroll(function() {
if ($(document).scrollTop() > 20) {
  $('#header').addClass('affix');
} else {
  $('#header').removeClass('affix');
}
});

$('.footer-title').click(function(){
		$(this).parent('.footer-nav').toggleClass('open');
	});


/*$('.dropdown-menu').click(function(e) {
    e.stopPropagation();
});*/


$('.hp-carousel').owlCarousel({
		items: 1,
		loop: false,
		dots: true,
		nav: false,
		center:false,		
		margin: 0,		
		autoplay:true,
	  smartSpeed:800,
    autoplayTimeout:8000,
		autoplayHoverPause:false,
		thumbs: false,
		thumbImage: false,
		autoHeight:true,
	});

$('.latest-carousel').owlCarousel({
		items: 1,
		loop: false,
		dots: true,
		nav: false,
		center:false,		
		margin: 0,		
		autoplay:false,
	  smartSpeed:800,
    autoplayTimeout:8000,
		autoplayHoverPause:false,
		thumbs: false,
		thumbImage: false,
		autoHeight:true,
	});

});
