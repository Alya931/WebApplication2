$(document).ready(function () {
    //Runs the Function when the Document is ready.
    var table = $("#ServiceCategoryDatatable").DataTable({
        "processing": true,//Enables the Processing Indicator
        "serverSide": true,// Enables Server-Side Processing
        "filter": true,//Displays the Search Box
        "ajax": { //AJAX POST call to api/customer
            "url": "/api/ViewServiceCategory_API",
            "type": "POST",
            "datatype": "json"
        },
        "columnDefs": [{//hide ID from the Datatable and not include it in the search.
            "targets": [0],
            "visible": true,
            "searchable": true
        }],
        "dom": 'Blfrtip',
        "buttons": [
            'colvis',
            'excel',
            'print'
        ],
        "columns": [ //the Array of all the Supported Columns.
            {
                "data": "idd", "name": "idd",
                render: function (data, type, row, meta) {
                    return meta.row + meta.settings._iDisplayStart + 1;
                }
            },
            //{ "data": "id", "name": "Id", "autoWidth": true },
            { "data": "categoryName", "name": "Name", "autoWidth": true },
          //  { "data": "smallDesc", "name": "smallDesc", "autoWidth": true },

            {
                "render": function (data, type, full, meta) {
                    return "<a class='btn btn-danger' onclick=Delete('" + full.categoryID + "');>delete</a> <a class='btn btn-info' onclick = GoToEditView('" + full.categoryID + "'); > Edit</a> <a class='btn btn-info' onclick = ViewData('" + full.categoryID + "'); >View</a>"
                }
            }
        ]
    });

});

////////////this function to edit the data///////////////
function GoToEditView(id) {

        window.location.href = '/EditServiceCategory/Edit/' + id;

}
////////////////////////////////////////////////////////

//////////////this function to delete the data//////////
function Delete(categoryID) {
    Swal.fire({
        title: 'Are you sure you want to delete row ' + categoryID + '?',
        showCancelButton: true,
        confirmButtonText: `Delete`,
    }).then((result) => {
        /* Read more about isConfirmed, isDenied below */
        if (result.isConfirmed) {
            $.ajax({
                url: "../DeleteServiceCategory/Delete",
                dataType: "json",
                data: JSON.stringify({ categoryID: categoryID }),
                contentType: 'application/json',
                type: "Post",
                success: function (responseMessage) {
                    swal.fire("Done!", "Row " + categoryID + " has been deleted successfully", '', "success");
                    $('#ServiceCategoryDatatable').DataTable().ajax.reload(null, false);
                }
            })
        } else {
            Swal.fire('Row ' + id + ' is not deleted', '', 'info')
        }
    });
}
////////////////////////////////////////////////////////////

//////////////this function to view the data////////////////
function ViewData(categoryID) {
    window.location.href = '/ViewServiceCategories/ViewData/' + categoryID;
}
////////////////////////////////////////////////////////////

////////////////////////////////////////////////////////////////////////////////////////////////Products DAtatable/////////////////////////////////////////////////////
$(document).ready(function () {
    //Runs the Function when the Document is ready.
    var table = $("#ProductCategoryDatatable").DataTable({
        "processing": true,//Enables the Processing Indicator
        "serverSide": true,// Enables Server-Side Processing
        "filter": true,//Displays the Search Box
        "ajax": { //AJAX POST call to api/customer
            "url": "/api/ViewProductCategory_API",
            "type": "POST",
            "datatype": "json"
        },
        "columnDefs": [{//hide ID from the Datatable and not include it in the search.
            "targets": [0],
            "visible": true,
            "searchable": true
        }],
        "dom": 'Blfrtip',
        "buttons": [
            'colvis',
            'excel',
            'print'
        ],
        "columns": [ //the Array of all the Supported Columns.
            {
                "data": "idd", "name": "idd",
                render: function (data, type, row, meta) {
                    return meta.row + meta.settings._iDisplayStart + 1;
                }
            },
            //{ "data": "id", "name": "Id", "autoWidth": true },
            { "data": "categoryName", "name": "Name", "autoWidth": true },
          //  { "data": "smallDesc", "name": "smallDesc", "autoWidth": true },

            {
                "render": function (data, type, full, meta) {
                    return "<a class='btn btn-danger' onclick=Delete1('" + full.categoryID + "');>delete</a> <a class='btn btn-info' onclick = GoToEditView1('" + full.categoryID + "'); > Edit</a> <a class='btn btn-info' onclick = ViewData1('" + full.categoryID + "'); >View</a>"
                }
            }
        ]
    });

});

////////////this function to edit the data///////////////
function GoToEditView1(categoryID) {

    window.location.href = '/EditProductCategory/Edit/' + categoryID;

}
////////////////////////////////////////////////////////

//////////////this function to delete the data/////////
function Delete1(categoryID) {
    Swal.fire({
        title: 'Are you sure you want to delete row ' + categoryID + '?',
        showCancelButton: true,
        confirmButtonText: `Delete`,
    }).then((result) => {
        /* Read more about isConfirmed, isDenied below */
        if (result.isConfirmed) {
            $.ajax({
                url: "../DeleteProductCategory/Delete",
                dataType: "json",
                data: JSON.stringify({ categoryID: categoryID }),
                contentType: 'application/json',
                type: "Post",
                success: function (responseMessage) {
                    swal.fire("Done!", "Row " + categoryID + " has been deleted successfully", '', "success");
                    $('#ProductCategoryDatatable').DataTable().ajax.reload(null, false);
                }
            })
        } else {
            Swal.fire('Row ' + categoryID + ' is not deleted', '', 'info')
        }
    });
}
////////////////////////////////////////////////////////////

//////////////this function to view the data////////////////
function ViewData1(categoryID) {
    window.location.href = '/ViewProductCategories/ViewData/' + categoryID;
}
////////////////////////////////////////////////////////////



//////////////////////////////////////////////////////////////////////Blogs category datatabel//////////////////////////////////////////////////////
$(document).ready(function () {
    //Runs the Function when the Document is ready.
    var table = $("#BlogCategoryDatatable").DataTable({
        "processing": true,//Enables the Processing Indicator
        "serverSide": true,// Enables Server-Side Processing
        "filter": true,//Displays the Search Box
        "ajax": { //AJAX POST call to api/customer
            "url": "/api/ViewBlogCategory_API",
            "type": "POST",
            "datatype": "json"
        },
        "columnDefs": [{//hide ID from the Datatable and not include it in the search.
            "targets": [0],
            "visible": true,
            "searchable": true
        }],
        "dom": 'Blfrtip',
        "buttons": [
            'colvis',
            'excel',
            'print'
        ],
        "columns": [ //the Array of all the Supported Columns.
            {
                "data": "idd", "name": "idd",
                render: function (data, type, row, meta) {
                    return meta.row + meta.settings._iDisplayStart + 1;
                }
            },
            //{ "data": "id", "name": "Id", "autoWidth": true },
            { "data": "categoryName", "name": "Name", "autoWidth": true },
          //  { "data": "smallDesc", "name": "smallDesc", "autoWidth": true },

            {
                "render": function (data, type, full, meta) {
                    return "<a class='btn btn-danger' onclick=Delete2('" + full.categoryID + "');>delete</a> <a class='btn btn-info' onclick = GoToEditView2('" + full.categoryID + "'); > Edit</a> <a class='btn btn-info' onclick = ViewData2('" + full.categoryID + "'); >View</a>"
                }
            }
        ]
    });

});

////////////this function to edit the data///////////////
function GoToEditView2(categoryID) {

    window.location.href = '/EditBlogCategory/Edit/' + categoryID;

}
////////////////////////////////////////////////////////

//////////////this function to delete the data/////////
function Delete2(categoryID) {
    Swal.fire({
        title: 'Are you sure you want to delete row ' + categoryID + '?',
        showCancelButton: true,
        confirmButtonText: `Delete`,
    }).then((result) => {
        /* Read more about isConfirmed, isDenied below */
        if (result.isConfirmed) {
            $.ajax({
                url: "../DeleteBlogCategory/Delete",
                dataType: "json",
                data: JSON.stringify({ categoryID: categoryID }),
                contentType: 'application/json',
                type: "Post",
                success: function (responseMessage) {
                    swal.fire("Done!", "Row " + id + " has been deleted successfully", '', "success");
                    $('#BlogCategoryDatatable').DataTable().ajax.reload(null, false);
                }
            })
        } else {
            Swal.fire('Row ' + categoryID + ' is not deleted', '', 'info')
        }
    });
}
////////////////////////////////////////////////////////////

//////////////this function to view the data////////////////
function ViewData2(categoryID) {
    window.location.href = '/ViewBlogCategories/ViewData/' + categoryID;
}
////////////////////////////////////////////////////////////

///////////////////////////////////////////////////////////////////////Projects Category Datatable///////////////////////////////////////////////////
$(document).ready(function () {
    //Runs the Function when the Document is ready.
    var table = $("#ProjectCategoryDatatable").DataTable({
        "processing": true,//Enables the Processing Indicator
        "serverSide": true,// Enables Server-Side Processing
        "filter": true,//Displays the Search Box
        "ajax": { //AJAX POST call to api/customer
            "url": "/api/ViewProjectCategory_API",
            "type": "POST",
            "datatype": "json"
        },
        "columnDefs": [{//hide ID from the Datatable and not include it in the search.
            "targets": [0],
            "visible": true,
            "searchable": true
        }],
        "dom": 'Blfrtip',
        "buttons": [
            'colvis',
            'excel',
            'print'
        ],
        "columns": [ //the Array of all the Supported Columns.
            {
                "data": "idd", "name": "idd",
                render: function (data, type, row, meta) {
                    return meta.row + meta.settings._iDisplayStart + 1;
                }
            },
            //{ "data": "id", "name": "Id", "autoWidth": true },
            { "data": "categoryName", "name": "Name", "autoWidth": true },
          //  { "data": "smallDesc", "name": "smallDesc", "autoWidth": true },

            {
                "render": function (data, type, full, meta) {
                    return "<a class='btn btn-danger' onclick=Delete3('" + full.categoryID + "');>delete</a> <a class='btn btn-info' onclick = GoToEditView3('" + full.categoryID + "'); > Edit</a> <a class='btn btn-info' onclick = ViewData3('" + full.categoryID + "'); >View</a>"
                }
            }
        ]
    });

});

////////////this function to edit the data///////////////
function GoToEditView3(categoryID)
{

    window.location.href = '/EditProjectCategory/Edit/' + categoryID;

}
////////////////////////////////////////////////////////

//////////////this function to delete the data/////////
function Delete3(categoryID) {
    Swal.fire({
        title: 'Are you sure you want to delete row ' + categoryID + '?',
        showCancelButton: true,
        confirmButtonText: `Delete`,
    }).then((result) => {
        /* Read more about isConfirmed, isDenied below */
        if (result.isConfirmed) {
            $.ajax({
                url: "../DeleteProjectCategory/Delete",
                dataType: "json",
                data: JSON.stringify({ categoryID: categoryID  }),
                contentType: 'application/json',
                type: "Post",
                success: function (responseMessage) {
                    swal.fire("Done!", "Row " + categoryID + " has been deleted successfully", '', "success");
                    $('#ProjectCategoryDatatable').DataTable().ajax.reload(null, false);
                }
            })
        } else {
            Swal.fire('Row ' + categoryID + ' is not deleted', '', 'info')
        }
    });
}
////////////////////////////////////////////////////////////

//////////////this function to view the data////////////////
function ViewData3(categoryID) {
    window.location.href = '/ViewProjectCategories/ViewData/' + categoryID;
}
////////////////////////////////////////////////////////////

