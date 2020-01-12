// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

const cakeControllerUri = "https://localhost:44323/api/cake/";
const categoryControllerUri = "https://localhost:44323/api/category/";

$(document).ready(function () {
    getCategories();
});

function populateDropdown(categories) {
    $.each(categories, function (key, category) {
        $("#categories").append(new Option(category.name, category.categoryId));
    });
}

function getCategories() {
    $.ajax({
        type: "GET",
        url: categoryControllerUri,
        cache: false,
        success: function (data) {
            populateDropdown(data);
        }
    });
}

function addCake() {
    var formData = new FormData();

    formData.append("name", $("#name").val());
    formData.append("price", $("#price").val());
    formData.append("description", $("#description").val());
    formData.append("categoryid", $("#categories").val());

    var file = $("#image")[0].files[0];
    if (file) {
        formData.append("image", file);
    }

    $.ajax({
        type: "POST",
        url: cakeControllerUri + "PostCake",
        processData: false,
        contentType: false,
        data: formData,
        mimeType: "multipart/form-data",
        cache: false,
        error: function (jqXHR, textStatus, errorThrown) {
            alert("Something went wrong!");
        },
        success: function (result) {
            alert("cake was added successfully!");
            window.location = "/homepage/index.html";
        }
    });

    return false;
}

$(".add-cake-form").on("submit", function () {
    addCake();

    return false;
});
