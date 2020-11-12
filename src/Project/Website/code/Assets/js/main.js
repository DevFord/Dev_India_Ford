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

// Home Page Carousel
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

// latest Carousel
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
	
// overview Slider
var mySwiper = new Swiper('.spy-overview .swiper-container', {
  loop: true,
  pagination: {
        el: '.spy-overview .swiper-pagination',
        clickable: true,
      },
});
// Safety Slider
var safetyThumbs = new Swiper('.safety-thumbs', {
      spaceBetween: 0,
      slidesPerView: 5,
			direction: 'vertical',
      loop: false,
      freeMode: false,
      loopedSlides: 5, //looped slides should be the same			
    });
    var safetySlide = new Swiper('.safety-slider', {
      spaceBetween: 0,
      loop: false,
      loopedSlides: 5, //looped slides should be the same      
      thumbs: {
        swiper: safetyThumbs,
      },
			autoplay: {
        delay: 5000,
        disableOnInteraction: false,
      },
});
		
// Fun Slider
var funThumbs = new Swiper('.fun-thumbs', {
      spaceBetween: 0,
      slidesPerView: 4,
      loop: false,
      freeMode: false,
      loopedSlides: 4, //looped slides should be the same
      watchSlidesVisibility: true,
      watchSlidesProgress: true,
    });
    var funSlide = new Swiper('.fun-slider', {
      spaceBetween: 0,
      loop: false,
      loopedSlides: 4, //looped slides should be the same      
      thumbs: {
        swiper: funThumbs,
      }
});

 /*var swiper = new Swiper('.tech-thumbs', {
      slidesPerView: 3.5,
			//autoHeight: true,
      direction: getDirection(),
      navigation: {
        nextEl: '.tech-thumbs .swiper-button-next',
        prevEl: '.tech-thumbs .swiper-button-prev',
      },
			pagination: {
        el: '.tech-thumbs .swiper-pagination',
        clickable: true,
      },
      on: {
        resize: function () {
          swiper.changeDirection(getDirection());
        }
      }
    });

    function getDirection() {
      var windowWidth = window.innerWidth;
      var direction = window.innerWidth >= 760 ? 'vertical' : 'horizontal';

      return direction;
    }*/

// Technology Slider
var techThumbs = new Swiper('.tech-thumbs', {
      spaceBetween: 0,
      slidesPerView: 3.5,
			direction: 'vertical',
			autoHeight: true,
      loop: false,
      freeMode: true,
			//slidesPerGroup: 3,
      //loopedSlides: 3, //looped slides should be the same
      watchSlidesVisibility: true,
      watchSlidesProgress: true,
			navigation: {
        nextEl: '.tech-thumbs .swiper-button-next',
        prevEl: '.tech-thumbs .swiper-button-prev',
      },
			pagination: {
					el: '.tech-thumbs .swiper-pagination',
					clickable: true,
				},			
    });
    var techSlide = new Swiper('.tech-slider', {
      spaceBetween: 0,
      loop: false,
      //loopedSlides: 3, //looped slides should be the same      
      thumbs: {
        swiper: techThumbs,
      },			
			pagination: {
					el: '.tech-slider .swiper-pagination',
					clickable: true,
				},
			autoplay: {
        delay: 5000,
        disableOnInteraction: false,
      },
});

// Review Slider
	var mySwiper = new Swiper('.review-swiper', {
		loop: true,		
		pagination: {
					el: '.review-swiper .swiper-pagination',
					clickable: true,
				},
	});
// Compare Slider
	var mySwiper = new Swiper('.compare-swiper', {
		slidesPerView: 4,
		spaceBetween: 30,
		slidesPerGroup: 4,
		loop: false,
		pagination: {
					el: '.compare-swiper .swiper-pagination',
					clickable: true,
				},
	});
});




