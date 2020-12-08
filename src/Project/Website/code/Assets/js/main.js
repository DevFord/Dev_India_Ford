// JavaScript Document
$(document).ready(function(){
var Wwidth = $(window).width();				
if (Wwidth > 768) {	
		$("header li.dropdown a").removeClass("dropdown-toggle");
}
if (Wwidth > 992) {
	$('.dropdown-toggle').click(function() { var location = $(this).attr('href'); window.location.href = location; return false; });
}

$('[data-toggle="popover"]').popover({
	html: true,
	});

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

//dropdown issue need to cofirm  with majis sir 
$(document).on('click', '.dropdown-menu', function (e) {
 e.stopPropagation();
});

$('a.page-scroll, .scrollspy-nav a').bind('click', function(event) {
		var $anchor = $(this);
		$('html, body').stop().animate({
				scrollTop: $($anchor.attr('href')).offset().top - 79
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

var hb = $('.hero-banner').height() + 200;
//alert(hb);
$(window).scroll(function() {    
    var scroll = $(window).scrollTop();
    if (scroll >= hb) {
				$(".breadcrumb-nav").addClass("is-open");
        $(".scrollspy-nav").removeClass("is-hide");
    } else {
			$(".breadcrumb-nav").removeClass("is-open");
			$(".scrollspy-nav").addClass("is-hide");
		}
});

$('.footer-title').click(function(){
		$(this).parent('.footer-nav').toggleClass('open');
	});


$('.accordion .collapse').on('shown.bs.collapse', function () {
			$(this).prev().parent().addClass('active');
				var $panel = $(this).closest('.card');
			$('html,body').animate({
				scrollTop: $panel.offset().top -80
			}, 700);
	});
	
	
// Home Page Slider
	var mySwiper = new Swiper('.hp-swiper', {
  loop: false,
	slidesPerView: 1,
  pagination: {
        el: '.hp-swiper .swiper-pagination',
        clickable: true,
      }
});
// Latest Banner Slider
	var mySwiper = new Swiper('.latest-swiper', {
  loop: false,
	slidesPerView: 1,
  pagination: {
        el: '.latest-swiper .swiper-pagination',
        clickable: true,
      }
});
	// Team Slider
	var mySwiper = new Swiper('.team-swiper', {
  loop: false,
	slidesPerView: 3,
  pagination: {
        el: '.team-swiper .swiper-pagination',
        clickable: true,
      }
});

// Single Slider
	var mySwiper = new Swiper('.single-swiper', {
  loop: false,
	slidesPerView: 1,
  pagination: {
        el: '.single-swiper .swiper-pagination',
        clickable: true,
      }
});

// Video Slider
	var mySwiper = new Swiper('.video-swiper', {
  loop: false,
	slidesPerView: 2,
  pagination: {
        el: '.video-swiper .swiper-pagination',
        clickable: true,
      }
});



// Scrollspy Navigation
$('body').scrollspy({target: ".scrollspy-nav", offset: 80});
var ft = $('.scrollspy-wrapper').height();
var ov = $('.spy-overview').height();
var ts = $('.sec-interest').height();
var gt = ft+ov-ts;
$(window).scroll(function() {    
    var scroll = $(window).scrollTop();
    if (scroll >= gt) {
        $(".scrollspy-nav").addClass("is-finish");
    } else {
			$(".scrollspy-nav").removeClass("is-finish");
		}
});
	
$('.spy-design .nav-link').on('shown.bs.tab', function (e) {
 $('.design-header').toggleClass('is-white');
});

// overview Slider
var mySwiper = new Swiper('.spy-overview .swiper-container', {
  loop: true,
  pagination: {
        el: '.spy-overview .swiper-pagination',
        clickable: true,
      },
	/*autoplay: {
        delay: 5000,
        disableOnInteraction: false,
      },*/
});

// Gallery Slider
var mySwiper = new Swiper('.gallery-swiper', {
  loop: false,
	slidesPerView: 2,
  pagination: {
        el: '.gallery-swiper .swiper-pagination',
        clickable: true,
      }
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
			/*autoplay: {
        delay: 5000,
        disableOnInteraction: false,
      },*/
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

// Technology Slider
var techThumbs = new Swiper('.tech-thumbs', {
      spaceBetween: 0,
      slidesPerView: 3.5,
			direction: 'vertical',
			autoHeight: true,
      loop: false,
      freeMode: true,
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
			breakpoints: {
				640: {
					slidesPerView: 2.5,	
				},
				768: {
					slidesPerView: 2.5,				
				},
				1024: {
					slidesPerView: 3.5,					
				},
			}		
    });
    var techSlide = new Swiper('.tech-slider', {
      spaceBetween: 0,
      loop: false,
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
		breakpoints: {
				640: {
					slidesPerView: 2,
				},
				768: {
					slidesPerView: 3,			
				},
				1024: {
					slidesPerView: 4,				
				},
			}	
	});
	
	
	
	if (Wwidth < 768) {			
		var mySwiper = new Swiper('.single-swiper-mobile', {
		loop: false,
		freeMode: false,
		slidesPerView: 1,
		pagination: {
					el: '.single-swiper-mobile .swiper-pagination',
					clickable: true,
				},
			breakpoints: {
				0: {
					slidesPerView: 1,
				},
				576: {
					slidesPerView: 2,			
				}
			}	
		});
}



});







