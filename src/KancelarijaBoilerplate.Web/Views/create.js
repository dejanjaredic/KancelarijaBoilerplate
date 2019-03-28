(function($) {
    $(function() {

        var _$form = $('#TaskCreationForm');

        _$form.find('uredjajname').focus();

        _$form.validate();

        _$form.find('button[type=submit]')
            .click(function(e) {
                e.preventDefault();

                if (!_$form.valid()) {
                    return;
                }

                var input = _$form.serializeFormToObject();
                abp.services.app.task.create(input)
                    .done(function() {
                        location.href = '/KreiranjeUredjaja';
                    });
            });
    });
})(jQuery);