const strHostName = 'Student';
var Table;
const UpdateModalCode = 1;
const AddModalCode = 2;

var arrDeletedSubjectID = new Array();

function Subtable(subject) {
    // `d` is the original data object for the row
    var html = '<table class="table subtable" cellpadding="5" cellspacing="0" border="0" style="padding-left:50px;">';
    html += '<thead><tr><th>Subject</th><th>Marks</th></tr></thead>'
    if (subject.length > 0) {



        $.each(subject, function (ind, val) {
            html += '<tr>';
            html += '<td>' + val.subjectName + '</td>';
            html += '<td>' + val.marks + '</td>';
            html += '</tr>';
        })



    }
    else {
        '<tr><td colspan="3">No Subjects Found !</td></tr>'
    }


    html += '</table>';

    return html;
}

//Student datatable initializer: this function is defined to initialize or populate student details in datatable
//on every call to it.
function StudentTable() {
    Table = $('#StudentTableId').DataTable({

        columnDefs: [
            { responsivePriority: 7, targets: -7, orderable: false },
            { responsivePriority: 6, targets: -6, orderable: false },          // Student Id
            { responsivePriority: 5, targets: -5, orderable: false },          // Student First Name
            { responsivePriority: 4, targets: -4, orderable: true },          // Student Last Name
            { responsivePriority: 3, targets: -3, orderable: true },          // Student Class
            { responsivePriority: 2, targets: -2, orderable: false },          // Student Subject
            { responsivePriority: 1, targets: -1, orderable: false },          // Student Marks
            { responsivePriority: 0, targets: 0, orderable: false },          // Student Marks

        ],

        "ajax": {
            "url": '/api/list',
            "type": "POST",
            "dataType": "JSON",
            "dataSrc": function dataSrc(json) {
                //console.log(json);
                return json.data;
            }
        },
        "order": [[3, "asc"]],
        "processing": true,
        "serverSide": true,
        "bFilter": true,
        "cache": false,
        responsive: true,
        "destroy": true,
        "paging": true,
        "columns": [
            {
                "className": 'details-control',
                "orderable": false,
                "data": null,
                "defaultContent": ''
            },
            { "data": "id" },
            { "data": "firstName" },//First Name
            { "data": "lastName" },//Last Name
            { "data": "class" },//Class
            { "data": null },//Subject
            { "data": null },//Marks
            { "data": null }//Actions
        ],
        "fnRowCallback": function (nRow, aData, iDisplayIndex, iDisplayIndexFull) {
            //console.log(aData);

            // Table.row.add();
            if (aData != undefined && aData != null) {
                var Subjects = "";
                var Marks = "";
                if (aData.subjects != undefined) {
                    if (aData.subjects.length >= 1) {

                        $.each(aData.subjects, function (ind, val) {

                            Subjects = Subjects == "" ? val.subjectName : Subjects + ',' + val.subjectName;
                            Marks = Marks == "" ? val.marks : Marks + ',' + val.marks;
                        })
                        //aData.Subject[0].subjectName;
                        //aData.Subject[0].marks;
                    }
                }

                $('td:eq(5)', nRow).html(Subjects);
                $('td:eq(6)', nRow).html(Marks);

               
            }

            $('td:eq(7)', nRow).html('<a onclick="EditModal(this)" >Edit</a> | <a onclick="deleteStudent(this)">Delete</a>');


        }

    });
}

//This function is defined to validate student detail form
function ValidateForm(FormId) {
    var bIsValidate = true;
    try {

        $("#" + FormId + " .form-group").each(function () {
            //console.log($(this).find('input').hasClass('required'));
            if ($(this).find('input').hasClass('required') && bIsValidate) {
                var val = $(this).find('input').val().trim();
                if (val == undefined || val == null || val.length == 0) {
                    $(this).find('input').addClass('error');
                    bIsValidate = false;

                }
            }
            else {

                return bIsValidate;
            }
        })

        if (bIsValidate && $('#' + FormId + ' .subject-container .subjects').children('div.subject').length == 0) {
            swal({
                title: "Warning !",
                text: "Please add at least one subject to continue!",
                icon: "info",
            });

            bIsValidate = false;
        }
    } catch (error) {
        console.log('ValidateForm Error : ', JSON.stringify(error));
        bIsValidate = false;
    }
    return bIsValidate;
}

//This function is defined to remove validation from the control.
function OnFocusRemoveValidation(obj) {
    $(obj).removeClass('error');
}

//This function is defined to delete student record by clicking on the delete button.
function deleteStudent(obj) {
    var nID = Table.row($(obj).closest('tr')).data().id;
    //console.log(JSON.stringify({ id: nID }));
    if (nID != null && nID != 0) {
        ajaxHelper('/api/' + nID, Method.DELETE, '').done(function (data) {

            // console.log(data);
            if (data != null && data.status) {
                swal({
                    title: "Success",
                    text: "Student added successfully!",
                    icon: "success",
                });
            }
            else {
                alert('Some error occured!');
            }
            StudentTable();
            $('#StudentCreateFormId').modal('hide');

        }).fail(function (jqXHR, textStatus, errorThrown) {
            console.log(' Add Student > Error: ' + errorThrown);
        });
        //$.ajax({
        //    type: 'DELETE',
        //    url: "/" + strHostName + "/Delete/",
        //    data: JSON.stringify({ id: nID }),
        //    contentType: "application/json; charset=utf-8",
        //    cache: false,
        //    success: function (data) {
        //        if (data) {
        //            swal({
        //                title: "Success",
        //                text: "Student was deleted from record.",
        //                icon: "success",
        //            });
        //            StudentTable();
        //        }
        //    },
        //    error: function () {

        //    },
        //    complete: function () {

        //    }
        //})
    }

    event.stopPropagation();

}

//This function is defined to clear update modal controls after exit.
function ClearAddModalControl() {
    $("#StudentDetailForm .closebtn").each(function () {
        $(this).trigger('click');
    });
    $('#StudentDetailForm input').val('');
}

//This function is defined to clear update modal controls after exit.
function ClearUpdateModalControl() {
    $('#UpdateStudentFormId input').val('');
    $("#UpdateStudentFormId .closebtn").each(function () {
        $(this).trigger('click');
    });
    arrDeletedSubjectID = [];
    //$('#update-subject-id').html('');
}

//This function is defined to update student data by an ajax call to the server after collecting the
//values from the update student detail form.
function UpdateStudent() {
    function getStudentFirstName() {
        var value = $('#update-first-name-id').val().trim();
        if (value == undefined || value == null) {
            return '';
        }
        else {
            return value;
        }
    }

    function getStudentLastName() {
        var value = $('#update-last-name-id').val().trim();
        if (value == undefined || value == null) {
            return '';
        }
        else {
            return value;
        }
    }

    function getStudentClass() {
        var value = $('#update-class-id').val().trim();
        if (value == undefined || value == null) {
            return '';
        }
        else {
            return value;
        }
    }
    try {
        if (ValidateForm('UpdateStudentDetailForm')) {
            var StudentData = $('#UpdateStudentFormId').data('StudentDetail');

            var ListOfSubject = new Array();
            $('#UpdateStudentDetailForm .subject').each(function () {
                var SubjectDetail = {
                    Id: $(this).find('[name="subject-name"]').attr('data-id') == undefined ? 0 : $(this).find('[name="subject-name"]').attr('data-id'),
                    SubjectName: $(this).find('[name="subject-name"]').val().trim(),
                    Marks: $(this).find('[name="marks"]').val().trim()
                }
                ListOfSubject.push(SubjectDetail);
            })

            var StudentDetail = {

                Id: StudentData.id,
                FirstName: getStudentFirstName(),
                LastName: getStudentLastName(),
                Class: getStudentClass(),
                Subjects: ListOfSubject,
                arrRemovedStudentSubjectId: arrDeletedSubjectID
            }

            //   console.log(JSON.stringify(StudentDetail));
            jQuery.ajaxSetup({ async: false, cache: false });

            ajaxHelper('/api/Update', Method.PUT, JSON.stringify(StudentDetail)).done(function (data) {
                $('#UpdateStudentFormId').modal('hide');
                // console.log(data);
                if (data.status) {
                    StudentTable();
                    swal({
                        title: "Success",
                        text: "Student added successfully!",
                        icon: "success",
                    });
                }
                else {
                    swal({
                        title: "Warning",
                        text: "Some error occured!",
                        icon: "warning",
                    });
                }
            }).fail(function (jqXHR, textStatus, errorThrown) {
                console.log(' Add Student > Error: ' + errorThrown);
            });
            //$.ajax({
            //    type: 'POST',
            //    url: "/" + strHostName + "/UpdateStudent",
            //    data: JSON.stringify(StudentDetail),
            //    contentType: "application/json; charset=utf-8",
            //    cache: false,
            //    success: function (data) {
            //        if (data.bStatus) {
            //            swal({
            //                title: "Success",
            //                text: "Student updated successfully!",
            //                icon: "success",
            //            });
            //        }
            //        else {
            //            alert('Some error occured!');
            //        }
            //    },
            //    error: function () {

            //    },
            //    complete: function () {
            //        StudentTable();
            //        ClearUpdateModalControl();
            //        $('#UpdateStudentFormId').modal('hide');
            //    }
            //})

            //console.log(ListOfSubject);
        }
        else {
            console.log('Please fill all required details.');
        }
    } catch (error) {
        console.log('UpdateStudent Error : ', JSON.stringify(error));
        bIsValidate = false;
    }
    event.stopPropagation();
}

// Get form element type
function getType(obj) {
    if (obj.tagName == "INPUT")
        return $(obj).attr("type").toLowerCase()
    else
        return obj.tagName.toLowerCase();
}

//This function is defined to pop-up update modal to make changes to all ready existing values.
function EditModal(obj) {
    var data = Table.row($(obj).closest('tr')).data();

    //console.log(data);
    if (data != undefined && data != null) {
        $("#update-first-name-id").val(data.firstName).attr('value', data.firstName);
        $("#update-last-name-id").val(data.lastName).attr('value', data.lastName);
        $("#update-class-id").val(data.class).attr('value', data.class);
        $("#update-first-name-id").attr('data-id', data.id);
        $.each(data.subjects, function (index, val) {
            cloneSubjectElement(val, UpdateModalCode);
        })

        $("#UpdateStudentFormId").data('StudentDetail', data).modal('show');
    }

    $('#updateStudent').prop('disabled', true);
    event.stopPropagation();

}

//This function is defined to add new student by getting student detail from the user and
//executing ajax request to the server to save it to database.
function AddStudent() {

    try {
        if (ValidateForm('StudentDetailForm')) {
            var StudentDetail;
            var ListOfSubject = new Array();

            $('.subject').each(function () {
                var SubjectDetail = {
                    'SubjectName': $(this).find('[name="subject-name"]').val().trim(),
                    'Marks': $(this).find('[name="marks"]').val().trim(),
                    //'Student': null,
                    //'StudentId':0
                }
                ListOfSubject.push(SubjectDetail);
            })

            var StudentDetail = JSON.stringify({
                'FirstName': getStudentFirstName(),
                'LastName': getStudentLastName(),
                'Class': getStudentClass(),
                'Subjects': ListOfSubject
            });

            console.log(StudentDetail);


            ajaxHelper('/api/add', Method.POST, StudentDetail).done(function (data) {
                if (data.bStatus) {
                    swal({
                        title: "Success",
                        text: "Student added successfully!",
                        icon: "success",
                    });
                }
                else {
                    alert('Some error occured!');
                }
                StudentTable();
                $('#StudentCreateFormId').modal('hide');

            }).fail(function (jqXHR, textStatus, errorThrown) {
                console.log(' Add Student > Error: ' + errorThrown);
            });

            //$.ajax({
            //    url: '/Student/Add',
            //    data: StudentDetail,
            //    cache: false,
            //    contentType: "application/json; charset=utf-8",
            //    dataType: "json",
            //    type: "POST",
            //    success: function (data) {

            //        if (data.bStatus) {
            //            swal({
            //                title: "Success",
            //                text: "Student added successfully!",
            //                icon: "success",
            //            });
            //        }
            //        else {
            //            alert('Some error occured!');
            //        }

            //    },
            //    error: function () {

            //    },
            //    complete: function () {
            //        StudentTable();
            //        $('#StudentCreateFormId').modal('hide');
            //    }
            //})

            //console.log(ListOfSubject);
        }
        else {
            console.log('Please fill all required details.');
        }


    } catch (error) {
        console.log('AddStudent Error : ', error);
        bIsValidate = false;
    }


    function getStudentFirstName() {
        var value = $('#first-name-id').val().trim();
        if (value == undefined || value == null) {
            return '';
        }
        else {
            return value;
        }
    }

    function getStudentLastName() {
        var value = $('#last-name-id').val().trim();
        if (value == undefined || value == null) {
            return '';
        }
        else {
            return value;
        }
    }

    function getStudentClass() {
        var value = $('#class-id').val().trim();
        if (value == undefined || value == null) {
            return '';
        }
        else {
            return value;
        }
    }
}

//This function is defined to remove extra subject form.
function removeSubjectElement(obj, nCode) {


    if (nCode == UpdateModalCode) {
        if ($(obj).parent().parent().attr('data-subject-id') != undefined)
            arrDeletedSubjectID.push($(obj).parent().parent().attr('data-subject-id'));

        if (arrDeletedSubjectID.length > 0)
            $('#updateStudent').prop('disabled', false);
    }

    $(obj).parents('.subject').remove();
    //console.log('Show');
    //To show add atleast one subject div
    if (nCode == UpdateModalCode) {
        if ($('#update-subject-id').children('div.subject').length > 0) {
            $('#update-subject-id').find('.add-subject-message').hide();
        }
        else if ($('#update-subject-id').children('div.subject').length == 0) {
            $('#update-subject-id').find('.add-subject-message').show();
        }
    }
    else if (nCode == AddModalCode) {
        if ($('#add-subject-id').children('div.subject').length > 0) {
            $('#add-subject-id').find('.add-subject-message').hide();
        }
        else if ($('#add-subject-id').children('div.subject').length == 0) {
            $('#add-subject-id').find('.add-subject-message').show();
        }
    }


}

//This function is defined to clone the subject div of the student.
function cloneSubjectElement(data, ncode) {
    // console.log(data);
    if (data == undefined || data == null) {
        var _strHtml = '';
        _strHtml += ' <div class="row subject ">';
        _strHtml += '<div class="col-sm-12 col-md-6">';
        _strHtml += ' <div class="form-group">  <label class="control-label">Subject Name</label>';
        _strHtml += '<div><input type="text" maxlength="30" placeholder="Enter name of the subject.." onfocus="OnFocusRemoveValidation(this)" class="form-control  required" name="subject-name" value="" ></div>';
        _strHtml += '</div></div>';
        _strHtml += '<div class="col-sm-4">';
        _strHtml += '<div class="form-group"><label class="control-label" > Marks</label>';
        _strHtml += '<div><input type="Number"  placeholder="Enter marks scored.." onfocus="OnFocusRemoveValidation(this)" class="form-control  required" onchange="handleChange(this);" name="marks" value="" ></div>';
        _strHtml += '</div></div>  ';


        if (ncode == UpdateModalCode) {
            _strHtml += '<div class="col-sm-2"><span class="btn btn-default closebtn" onclick="removeSubjectElement(this,' + UpdateModalCode + ')" style="float:right;">x</div></div>';
            $('#update-subject-id').prepend(_strHtml);
        }

        else if (ncode == AddModalCode) {
            _strHtml += '<div class="col-sm-2"><span class="btn btn-default closebtn" onclick="removeSubjectElement(this,' + AddModalCode + ')" style="float:right;">x</div></div>';
            $('#add-subject-id').prepend(_strHtml);
        }

    }
    else {
        var _strHtml = '';
        _strHtml += ' <div class="row subject" data-subject-id="' + data.id + '">';
        _strHtml += '<div class="col-md-5 col-sm-5">';
        _strHtml += ' <div class="form-group">  <label class="control-label">Subject Name</label>';
        _strHtml += '<div><input type="text" maxlength="30" placeholder="Enter name of the subject.." onfocus="OnFocusRemoveValidation(this)" class="form-control  required" name="subject-name" data-id="' + data.id + '" value="' + data.subjectName + '" ></div>';
        _strHtml += '</div></div>';
        _strHtml += '<div class="col-md-5 col-sm-5">';
        _strHtml += '<div class="form-group"><label class="control-label" > Marks</label>';
        _strHtml += '<div><input type="Number" onfocus="OnFocusRemoveValidation(this)" class="form-control  required" onchange="handleChange(this);" name="marks" value="' + data.marks + '"></div>';
        _strHtml += '</div></div>  ';
        _strHtml += '<div class="col-sm-2"><span class="btn btn-default closebtn" onclick="removeSubjectElement(this,UpdateModalCode)" style="float:right;">x</div></div>';
        $('#update-subject-id').prepend(_strHtml);
    }

    $('.add-subject-message').hide();
}


function GetStudentSubjectHtml(lstStudentSubject) {
    var _strHtml = "";
    if (lstStudentSubject != null && lstStudentSubject != undefined) {

        $.each(lstStudentSubject, function (index, value) {
            _strHtml += '<tr>';
            _strHtml += '<td>' + ++index + '</td>';
            _strHtml += '<td>' + value.subjectName + '</td>';
            _strHtml += '<td>' + value.marks + '</td>';
            _strHtml += '</tr>';
        });
    }
    else {
        _strHtml += '<tr colspan="3">No subject found.</tr>';
    }
    return _strHtml;
}
//Here the ready function defined to call all function on ready state of the page.
$(document).ready(function () {
    StudentTable();
    // Check values on change
    $('#UpdateStudentDetailForm').bind('change keyup', function () {
        console.log('hello');
        var disable = true;
        if (arrDeletedSubjectID.length > 0)
            disable = false;
        if (disable) {
            $("form :input").each(function () {
                var type = getType(this);
                if (type == 'text' || type == 'number') {
                    disable = ($(this).attr('value') == $(this).val().trim());
                }
                if (!disable) { return false; } // break out of loop
            });
        }


        $('#updateStudent').prop('disabled', disable); // update button
    });

    $(document).on('click', '#StudentTableId tbody tr', function () {
        var data = Table.row($(this).closest('tr')).data();

        $("#student-name-id").text(data.firstName + " " + data.lastName);

        $("#student-class-id").text(data.class);

        if (data.subjects != null && data.subjects != undefined) {
            //$("#student-subject-id").html(GetStudentSubjectHtml(data.Subject));
            $('#student-subject-id').DataTable({
                data: data.subjects,
                destroy: true,
                searching: false,
                responsive: false,
                "lengthChange": false,
                width: "1000px",

                columns: [
                    { "data": "id" },
                    { "data": "subjectName" },
                    { "data": "marks" },

                ]
            });
        }


        $('#StudentDetailModalId').modal('show');
    });


    $('#StudentTableId tbody').on('click', 'td.details-control', function () {
        var tr = $(this).closest('tr');
        var row = Table.row(tr);

        console.log(row);
        if (row.child.isShown()) {
            // This row is already open - close it
            row.child.hide();
            tr.removeClass('shown');
        }
        else {
            // Open this row
            row.child(Subtable(row.data().subjects)).show();
            tr.addClass('shown');
        }

        event.stopPropagation();
    });

    //pay attention to capital D, which is mandatory to retrieve "api" datatables' object, as @Lionel said
    $('#myInputTextField').keyup(function () {
        StudentTable.search($(this).val()).draw();
    })

    $(document).on('click', '#add-student-btn-id', function () {
        ClearAddModalControl();
    })


});


function handleChange(input) {
    console.log(input.value);
    if (input.value < 0) input.value = 0;
    if (input.value > 100) input.value = 100;
}
