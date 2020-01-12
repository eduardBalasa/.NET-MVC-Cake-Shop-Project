const cakeControllerUri = "https://localhost:44323/api/cake/";
const categoryControllerUri = "https://localhost:44323/api/category/";

$(document).ready(function () {
	document.getElementById("loader").style.display = "block";

	getCakes();
	getSampleCakesImages();
	getCategories();
	bindSearchCakes();

});

function displayCakes(cakes) {
	$("#cakes").empty();

    $.each(cakes, function (key, cake) {

        $("#cakes").append('<div class="col-lg-4 col-md-6 mb-4"><div class="card h-100"><a href="#"><img class="card-img-top" height="200" src="' + (cake.base64Image ? cake.base64Image : "http://placehold.it/700x400" ) + '" alt=""></a><div class="card-body"><h4 class="card-title"><a href="/item/index.html?cakeid=' + cake.cakeId + '">' + cake.name + '</a></h4><h5>' + cake.price + ' lei</h5><p class="card-text">' + cake.description + '</p></div><h5 style="margin-left:1.25rem">' + cake.category + '</h5><div class="card-footer"><small class="text-muted">&#9733; &#9733; &#9733; &#9733; &#9734;</small><button type="button" onclick="deleteCake(' + cake.cakeId + ');" class="btn btn-danger" style="float: right;">Stergere</button></div></div></div>');
    });

}

function getCakes() {
    $.ajax({
        type: "GET",
        url: cakeControllerUri,
        cache: false,
        success: function (cakes) {
			displayCakes(cakes);

			document.getElementById("loader").style.display = "none";
        }
    });
}

function createCategoriesMenu(categories) {
	$("#categories").empty();
	$.each(categories, function (key, category) {
		$("#categories").append('<a href="javascript:filterByCategory(' + category.categoryId + ');" class="list-group-item">' + category.name + '</a>');
	});

	$("#categories").append('<a href="javascript:filterByCategory(0);" class="list-group-item">Toate categoriile</a>');
}


function getSampleCakesImages() {
	$.ajax({
		type: "GET",
		url: cakeControllerUri + "GetSampleCakesImages",
		cache: false,
		success: function (sampleImagesObj) {
			$('#sample-image-1').attr("src", sampleImagesObj.base64Image1);
			$('#sample-image-2').attr("src", sampleImagesObj.base64Image2);
			$('#sample-image-3').attr("src", sampleImagesObj.base64Image3);
		}
	});
}

function deleteCake(id) {
    $.ajax({
        url: cakeControllerUri + id,
        type: "DELETE",
        success: function (result) {
            alert("cake was deleted successfully!");
            location.reload();
        }
    });
}

function bindSearchCakes() {
	$('input[name=search-control]').on('input', function () {
		document.getElementById("loader").style.display = "block";
		var searchText = $('input[name=search-control]').val();

		$.ajax({
			type: "GET",
			url: cakeControllerUri + "?searchText=" + searchText,
			cache: false,
			success: function (cakes) {
				displayCakes(cakes);
				document.getElementById("loader").style.display = "none";
			}
		});
	});
}

function getCategories() {
	$.ajax({
		type: "GET",
		url: categoryControllerUri,
		cache: false,
		success: function (categories) {
			createCategoriesMenu(categories);
		}
	});
}

function filterByCategory(categoryId) {
	// ajax to get based on categor id cakes
	var searchText = $('input[name=search-control]').val();

	$.ajax({
		type: "GET",
		url: cakeControllerUri + "?searchText=" + searchText + "&categoryId=" + categoryId,
		cache: false,
		success: function (cakes) {
			displayCakes(cakes);
		}
	});
}



