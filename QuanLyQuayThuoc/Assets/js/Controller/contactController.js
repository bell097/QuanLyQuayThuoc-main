var contact = {
    init: function () {
        contact.registerEvents();

    },
    registerEvents: function () {
        $('#btnSend').off('click').on('click', function (){
            var name = $('#txtName').val();
            var email = $('#txtEmail').val();
            var phone = $('#txtPhone').val();
            var message = $('#txtMessage').val();

            $.ajax({
                url: '/Contact/Send',
                type: 'POST',
                dataType: 'json',
                data: {
                    name: name,
                    email: email,
                    phone: phone,
                    message: message
                },
                success: function (res) {
                    if (res.status == true) {
                        window.alert('Gửi thành công');
                        contact.resetForm();
                    }
                }
            });
        });
    },
    resetForm: function () {
       $('#txtName').val('');
       $('#txtEmail').val('');
       $('#txtPhone').val('');
       $('#txtMessage').val('');
    }
}
contact.init();