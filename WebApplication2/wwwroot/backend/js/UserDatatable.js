$(document).ready(function () {
    //Runs the Function when the Document is ready.
    var table = $("#customerDatatable").DataTable({
        "processing": true,//Enables the Processing Indicator
        "serverSide": true,// Enables Server-Side Processing
        "filter": true,//Displays the Search Box
        "ajax": { //AJAX POST call to api/customer
            "url": "/api/User1",
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
            { "data": "firstName", "name": "FirstName", "autoWidth": true },
            { "data": "email", "name": "Email", "autoWidth": true },
            { "data": "status", "name": "status", "autoWidth": true },
            { "data": "roles", "name": "Roles", "autoWidth": true },
            {
                "render": function (data, type, full, meta) {
                    return "<a class='btn btn-danger' onclick=Delete('" + full.id + "');>delete</a> <a class='btn btn-info' onclick = GoToEditView('" + full.id + "'); > Edit</a> <a class='btn btn-info' onclick = ViewData('" + full.id + "'); >View</a>"
                }
            }
        ]
    });

});



//delete row from database function that uses ajax
function Delete(id) {
    Swal.fire({
        title: 'Are you sure you want to delete the user?',
        showCancelButton: true,
        confirmButtonText: `Delete`,
    }).then((result) => {
        /* Read more about isConfirmed, isDenied below */
        if (result.isConfirmed) {
            $.ajax({
                url: "../DeleteUser/Delete",
                dataType: "json",
                data: JSON.stringify({ id: id }),
                contentType: 'application/json',
                type: "Post",
                success: function (responseMessage) {
                    swal.fire("Done!", "The user has been deleted successfully", '', "success");
                    $('#customerDatatable').DataTable().ajax.reload(null, false);
                }
            })
        } else {
            Swal.fire('Row ' + id + ' is not deleted', '', 'info')
        }
    });
}


////////////view user details////////////
function ViewData(id) {
    window.location.href = '/View/ViewData/' + id;
}
/////////////////////////////////////////



/////////////edit function///////////////
function GoToEditView(id) {

    window.location.href = '/Edit/Edit/' + id;

}