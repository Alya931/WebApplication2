$(document).ready(function () {
    //Runs the Function when the Document is ready.
    var table = $("#BlogsDatatable").DataTable({
        "processing": true,//Enables the Processing Indicator
        "serverSide": true,// Enables Server-Side Processing
        "filter": true,//Displays the Search Box
        "ajax": { //AJAX POST call to api/customer
            "url": "/api/ViewBlog_API",
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
            { "data": "title", "name": "title", "autoWidth": true },
            { "data": "smallDesc", "name": "smallDesc", "autoWidth": true },

            {
                "render": function (data, type, full, meta) {
                    return "<a class='btn btn-danger' onclick=Delete('" + full.id + "');>delete</a> <a class='btn btn-info' onclick = GoToEditView('" + full.id + "'); > Edit</a> <a class='btn btn-info' onclick = ViewData('" + full.id + "'); >View</a>"
                }
            }
        ]
    });

});




///////////this function to edit the data///////////////
function GoToEditView(id) {

    window.location.href = '/EditBlog/Edit/' + id;

}
function GoToEditView1(id) {
    $.ajax({
        url: 'Backend/Blogs/Edit/Edit',
        dataType: "json",
        data: JSON.stringify({ id: id }),
        contentType: 'application/json',
        type: "Post",
        success: function (responseMessage) {
            swal.fire("Done!", "Row " + id + " has been deleted successfully", '', "success");
            $('#BlogsDatatable').DataTable().ajax.reload(null, false);
        }
    })
}
///////////////////////////////////////////////////////


//////////////this function to delete the data////////////
function Delete(id) {
    Swal.fire({
        title: 'Are you sure you want to delete row ' + id + '?',
        showCancelButton: true,
        confirmButtonText: `Delete`,
    }).then((result) => {
        /* Read more about isConfirmed, isDenied below */
        if (result.isConfirmed) {
            $.ajax({
                url: "../DeleteBlog/Delete",
                dataType: "json",
                data: JSON.stringify({ id: id }),
                contentType: 'application/json',
                type: "Post",
                success: function (responseMessage) {
                    swal.fire("Done!", "Row " + id + " has been deleted successfully", '', "success");
                    $('#BlogsDatatable').DataTable().ajax.reload(null, false);
                }
            })
        } else {
            Swal.fire('Row ' + id + ' is not deleted', '', 'info')
        }
    });
}
////////////////////////////////////////////////////////////

////////////////////this function to view the data//////////
function ViewData(id) {
    window.location.href = '/ViewBlogs/ViewData/' + id;
}
////////////////////////////////////////////////////////////


