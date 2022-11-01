//Service category Addition and deletion
function sweetAlertService() {
    (async () => {
        const { value: formValues } = await Swal.fire({
            title: 'Add new service category',
            html:
                '<input id="swal-input1" class="swal2-input">',
            focusConfirm: false,
            preConfirm: () => {
                return [
                    document.getElementById('swal-input1').value,
                ]
            }
        })
        var category = document.getElementById('swal-input1').value;
        AddServiceCategory(category);
    })()
}

function AddServiceCategory(CategoryName)
{
    Swal.fire({
        title: 'Are you sure you want to add category \"' + CategoryName + '\"?',
        showCancelButton: true,
        confirmButtonText: `ADD`,
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                type: "POST",
                url: "../CreateServiceCategory/Create1",
                contentType: "application/json",
                dataType: "json",
                data: JSON.stringify({ CategoryName: CategoryName }),
                success: function (responseMessage) { 
                    swal.fire("Done!", "category  \"" + CategoryName + "\" has been added ", '', "success");
                    window.location.reload();
                },
                error: function (responseMessage) {
                    swal.fire("error!", "category has not been added ", '', "info");
                }
            })
        } else {
            Swal.fire('category ' + CategoryName + ' is not Added', '', 'info')
        }
    });
}

//function Delete(categoryID) {
//    Swal.fire({
//        title: 'Are you sure you want to delete row ' + categoryID + '?',
//        showCancelButton: true,
//        confirmButtonText: `Delete`,
//    }).then((result) => {
//        /* Read more about isConfirmed, isDenied below */
//        if (result.isConfirmed) {
//            $.ajax({
//                url: "../DeleteServiceCategory/Delete",
//                dataType: "json",
//                data: JSON.stringify({ categoryID: categoryID }),
//                contentType: 'application/json',
//                type: "Post",
//                success: function (responseMessage) {
//                    window.location.reload();
//                    swal.fire("Done!", "Row " + categoryID + " has been deleted successfully", '', "success");
//                }
//            })
//        } else {
//            Swal.fire('Row ' + id + ' is not deleted', '', 'info')
//        }
//    });
//}
///////////////////////////////////////////////////

//Product Category Addition and deletion
function sweetAlertProduct() {
    (async () => {
        const { value: formValues } = await Swal.fire({
            title: 'Add new Product category',
            html:
                '<input id="swal-input1" class="swal2-input">',
            focusConfirm: false,
            preConfirm: () => {
                return [
                    document.getElementById('swal-input1').value,
                ]
            }
        })
        var category = document.getElementById('swal-input1').value;
        AddProductCategory(category);
    })()
}

function AddProductCategory(CategoryName) {
    Swal.fire({
        title: 'Are you sure you want to add category \"' + CategoryName + '\"?',
        showCancelButton: true,
        confirmButtonText: `ADD`,
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                type: "POST",
                url: "../CreateProductCategory/Create1",
                contentType: "application/json",
                dataType: "json",
                data: JSON.stringify({ CategoryName: CategoryName }),
                success: function (responseMessage) {
                    swal.fire("Done!", "category  \"" + CategoryName + "\" has been added ", '', "success");
                    window.location.reload();
                },
                error: function (responseMessage) {
                    swal.fire("error!", "category has not been added ", '', "info");
                }
            })
        } else {
            Swal.fire('category ' + CategoryName + ' is not Added', '', 'info')
        }
    });
}
////////////////////////
//project addition and deletion of category

function sweetAlertProject() {
    (async () => {
        const { value: formValues } = await Swal.fire({
            title: 'Add new Project category',
            html:
                '<input id="swal-input1" class="swal2-input">',
            focusConfirm: false,
            preConfirm: () => {
                return [
                    document.getElementById('swal-input1').value,
                ]
            }
        })
        var category = document.getElementById('swal-input1').value;
        AddProjectCategory(category);
    })()
}

function AddProjectCategory(CategoryName) {
    Swal.fire({
        title: 'Are you sure you want to add category \"' + CategoryName + '\"?',
        showCancelButton: true,
        confirmButtonText: `ADD`,
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                type: "POST",
                url: "../CreateProjectCategory/Create1",
                contentType: "application/json",
                dataType: "json",
                data: JSON.stringify({ CategoryName: CategoryName }),
                success: function (responseMessage) {
                    swal.fire("Done!", "category  \"" + CategoryName + "\" has been added ", '', "success");
                    window.location.reload();
                },
                error: function (responseMessage) {
                    swal.fire("error!", "category has not been added ", '', "info");
                }
            })
        } else {
            Swal.fire('category ' + CategoryName + ' is not Added', '', 'info')
        }
    });
}


///////////////////////////////////////
//blog addition of a category


function sweetAlertBlog() {
    (async () => {
        const { value: formValues } = await Swal.fire({
            title: 'Add new Blog category',
            html:
                '<input id="swal-input1" class="swal2-input">',
            focusConfirm: false,
            preConfirm: () => {
                return [
                    document.getElementById('swal-input1').value,
                ]
            }
        })
        var category = document.getElementById('swal-input1').value;
        AddBlogCategory(category);
    })()
}

function AddBlogCategory(CategoryName) {
    Swal.fire({
        title: 'Are you sure you want to add category \"' + CategoryName + '\"?',
        showCancelButton: true,
        confirmButtonText: `ADD`,
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                type: "POST",
                url: "../CreateBlogCategory/Create1",
                contentType: "application/json",
                dataType: "json",
                data: JSON.stringify({ CategoryName: CategoryName }),
                success: function (responseMessage) {
                    swal.fire("Done!", "category  \"" + CategoryName + "\" has been added ", '', "success");
                    window.location.reload();
                },
                error: function (responseMessage) {
                    swal.fire("error!", "category has not been added ", '', "info");
                }
            })
        } else {
            Swal.fire('category ' + CategoryName + ' is not Added', '', 'info')
        }
    });
}