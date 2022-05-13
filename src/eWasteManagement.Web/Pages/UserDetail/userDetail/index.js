$(function () {

    var l = abp.localization.getResource('eWasteManagement');

    var service = eWasteManagement.userDetail.userDetail;
    var createModal = new abp.ModalManager(abp.appPath + 'UserDetail/userDetail/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'UserDetail/userDetail/EditModal');

    var dataTable = $('#userDetailTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible: abp.auth.isGranted('eWasteManagement.userDetail.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('eWasteManagement.userDetail.Delete'),
                                confirmMessage: function (data) {
                                    return l('userDetailDeletionConfirmationMessage', data.record.customerName);
                                },
                                action: function (data) {
                                    service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            {
                title: l('CustomerName'),
                data: "customerName"
            },
            {
                title: l('Gender'),
                data: "gender",
                render: function (data) {
                    return l('Enum:sex:' + data);
                }
            },
            {
                title: l('EmailId'),
                data: "emailId"
            },
           
            {
                title: l('Location'),
                data: "location"
            },
            {
                title: l('Type'),
                data: "type",
                render: function (data) {
                    return l('Enum:Types:' + data);
                }
            },
            {
                title: l('Date'),
                data: "date",
                render: function (data) {
                    return luxon
                        .DateTime
                        .fromISO(data, {
                            locale: abp.localization.currentCulture.name
                        }).toLocaleString();
                }
            },
            {
                title: l('Mobile'),
                data: "phoneNo"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewuserDetailButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
