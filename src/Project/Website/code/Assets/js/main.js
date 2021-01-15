// JavaScript Document
$(document).ready(function(){
var Wwidth = $(window).width();				
if (Wwidth > 768) {	
		$("header li.dropdown a").removeClass("dropdown-toggle");
}
if (Wwidth > 992) {
	$('.dropdown-toggle').click(function() { var location = $(this).attr('href'); window.location.href = location; return false; });
}

$('#searchModal').on('show.bs.modal', function(){
	setTimeout(function (){
        $('#searchInput').focus();
    }, 1000);
});
$('[data-toggle="tooltip"]').tooltip();
$('[data-toggle="popover"]').popover({
	html: true,
	});

var compareItem = "<div class='compare-item-selected'><button class='btn-remove'>&times;</button><img src='images/model/small/endeavour.png' alt=''><a href='#' class='d-flex align-items-center h4 m-0' data-toggle='dropdown'><span class='text-truncate'>2.0L Diesel 4x2 AT</span> <i class='fa fa-chevron-down text-muted ml-auto pl-3'></i></a><div class='dropdown-menu'><a href='#' class='dropdown-item'>2.0L Diesel 4x2 AT</a><a href='#' class='dropdown-item'>2.0L Diesel 4x2 AT</a><a href='#' class='dropdown-item'>2.0L Diesel 4x2 AT</a><a href='#' class='dropdown-item'>2.0L Diesel 4x2 AT</a></div><div class='price text-muted h5 mb-0 mt-2'><i class='fa fa-rupee'></i> 29,99,000</div></div>";
	var compareDropdown = "<div class='d-flex align-items-end h-100 model-dropdown'><div class='dropdown w-100'><a href='#' class='dropdown-btn d-flex align-items-center h4 m-0' data-toggle='dropdown'>Add Modal <br>to compare <i class='fa fa-chevron-down text-muted ml-auto'></i></a><div class='dropdown-menu'><a href='#' class='dropdown-item'>2.0L Diesel 4x2 AT</a><a href='#' class='dropdown-item'>2.0L Diesel 4x2 AT</a><a href='#' class='dropdown-item'>2.0L Diesel 4x2 AT</a><a href='#' class='dropdown-item'>2.0L Diesel 4x2 AT</a></div></div></div>";
	
	
	
$('.compare-item').on('click', '.btn-remove', function(e){ 	
		//alert ('Hi');		
		$(this).parent().parent().addClass('is-empty');
		$(this).parent().parent('.compare-item').prepend(compareDropdown);
		$(this).parent('.compare-item-selected').remove();			
					
	});
	
	$('.compare-item').one('click', '.dropdown-item', function(e){ 			
		//alert ('Hi');		
		$(this).parent().parent().parent().parent().removeClass('is-empty');
		$(this).parent().parent().parent().parent().before().prepend(compareItem);
		$(this).parent().parent().parent('.model-dropdown').remove();
		return false
	});

$('.hamburger, .bg-overlay').click(function(e){ 
		e.stopPropagation();
		$('#navbar').fadeIn().toggleClass('is-open');
		$('.hamburger').toggleClass('is-active');
		$('body').toggleClass('no-scroll');			
		$('#header .dropdown-menu .nav-item').removeClass('open');	
		$('#navbar .dropdown-menu, #navbar .dropdown').removeClass("show");		
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
  $('#header, .compare-filter').addClass('affix');
} else {
  $('#header, .compare-filter').removeClass('affix');
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
      },
	breakpoints: {
				0: {
					slidesPerView: 1,	
				},
				540: {
					slidesPerView: 2,	
				},
				768: {
					slidesPerView: 3,					
				},
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
      },
		breakpoints: {
				0: {
					slidesPerView: 1,	
				},
				768: {
					slidesPerView: 2,					
				},
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
	

$('.spy-design .nav-link-design').on('shown.bs.tab', function (e){	
	$('.spy-design').removeClass('is-active');
});
$('.design-tab a').on('shown.bs.tab', function (e){
	$('.spy-design').removeClass('is-white');
});
$('.spy-design .nav-link-interior').on('shown.bs.tab', function (e){
	$('.spy-design').addClass('is-white');
});
$('.spy-design .nav-link-interior, .spy-design .nav-link-exterior').on('shown.bs.tab', function (e){
	$('.spy-design').addClass('is-active');
});



/*if ($('.spy-design .nav-link').on('shown.bs.tab', function (e)) {
	{
 $('.spy-design').toggleClass('is-white');
	} else {
		
	}
});*/

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
      },
	breakpoints: {
				0: {
					slidesPerView: 2,
				},
				576: {
					slidesPerView: 3,					
				},
				768: {
					slidesPerView: 2,	
				},
			},	
		
});

// Safety Slider
var safetyThumbs = new Swiper('.safety-thumbs', {
      spaceBetween: 0,
      slidesPerView: 5,
			direction: 'vertical',
      loop: false,
      freeMode: true,
      watchSlidesVisibility: true,
      watchSlidesProgress: true,
			breakpoints: {
				0: {
					slidesPerView: 2,	
					 spaceBetween: 30,
					direction: 'horizontal',
				},
				480: {
					slidesPerView: 3,	
					 spaceBetween: 30,
					direction: 'horizontal',
				},
				768: {
					slidesPerView: 5,				
				}
			}				
    });
    var safetySlide = new Swiper('.safety-slider', {
      spaceBetween: 0,
      loop: false,       
      thumbs: {
        swiper: safetyThumbs,
      },
			autoplay: {
        delay: 5000,
        disableOnInteraction: false,
      },
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
					clickable: false,
					type: 'progressbar',
				},	
			breakpoints: {
				0: {
					slidesPerView: 1,	
					direction: 'horizontal',
					allowTouchMove:false,					
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
				/*autoplay: {
					delay: 5000,
					disableOnInteraction: false,
				},	*/
});
		
// Fun Slider
var funThumbs = new Swiper('.fun-thumbs', {
      spaceBetween: 0,
      slidesPerView: 4,
      loop: false,
      freeMode: false,
			spaceBetween: 20,
      loopedSlides: 4, //looped slides should be the same
      watchSlidesVisibility: true,
      watchSlidesProgress: true,
			breakpoints: {
				0: {
					slidesPerView: 2,	
					loopedSlides: 2,
					autoHeight: true,
				},
				480: {
					slidesPerView: 3,
					loopedSlides: 3,					
					autoHeight: true,
				},
				575: {	
					slidesPerView: 4,					
					loopedSlides: 4,
					autoHeight: true,
				},
				768: {
					slidesPerView: 4,	
					loopedSlides: 4,
				}
			}		
    });
    var funSlide = new Swiper('.fun-slider', {
      spaceBetween: 0,
      loop: false,
      loopedSlides: 4, //looped slides should be the same      
      thumbs: {
        swiper: funThumbs,
      },
			pagination: {
        el: '.fun-slider .swiper-pagination',
        clickable: true,
      }
});


var mySwiper = new Swiper('.style-swiper', {
		spaceBetween: 0,
		autoHeight: true,
		loop: false,
		pagination: {
					el: '.style-swiper .swiper-pagination',
					clickable: true,
				},
		breakpoints: {
				0: {
					slidesPerView: 1,
					slidesPerGroup: 1,
				},
				576: {
					slidesPerView: 2,
					slidesPerGroup: 2,
					
				},
				768: {
					slidesPerView: 3,	
					slidesPerGroup: 3,	
				},
			}	
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
		autoHeight: true,
		loop: false,
		pagination: {
					el: '.compare-swiper .swiper-pagination',
					clickable: true,
				},
		breakpoints: {
				0: {
					slidesPerView: 1,
					slidesPerGroup: 1,
				},
				576: {
					slidesPerView: 2,
					slidesPerGroup: 2,
					
				},
				768: {
					slidesPerView: 3,	
					slidesPerGroup: 3,	
				},
				1024: {
					slidesPerView: 4,				
				},
			}	
	});
	
	
	
	if (Wwidth < 768) {			
		var mySwiper = new Swiper('.single-swiper-mobile, .feature-slider', {
		loop: false,
		freeMode: false,
		slidesPerView: 1,
		pagination: {
					el: '.single-swiper-mobile .swiper-pagination, .feature-slider .swiper-pagination',
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
$(window).on("load resize", function() {
  if (this.matchMedia("(min-width: 1200px)").matches) {
//    alert ('Hi');
		$('ul.dropdown-menu [data-toggle=dropdown]').on('click', function(event) {
			event.preventDefault(); 
			event.stopPropagation(); 
			$(this).parent().siblings().removeClass('open');
			$(this).parent().addClass('open');
		});
		$(document).on('click', '.dropdown-menu', function (e) {
		 e.stopPropagation();
		});
  } else {
   // alert ('Hello');
		$('.dropdown-submenu .nav-link').removeAttr('data-toggle');
  }
});