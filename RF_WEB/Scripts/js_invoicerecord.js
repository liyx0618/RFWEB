(function ($) {
    $.invoices = {
        initData: function () {
            var dutyTable = $(".table-sort").dataTable({
                "destroy": true,       //销毁表格对象
                "aLengthMenu": [5, 10],  //用户可自选每页展示数量 5条或10条
                "searching": false,//禁用搜索（搜索框）
                "lengthChange": true,
                "paging": true,//开启表格分页
                "bProcessing": true,
                "bServerSide": true,
                "bAutoWidth": false,
                //"sort" : "position",
                "deferRender": true,//延迟渲染
                //"bStateSave": false, //在第三页刷新页面，会自动到第一页
                //"retrieve": true,       //类似单例模式，重复利用以存在对象。
                "iDisplayLength": 5,
                "iDisplayStart": 0,
                "select": {
                    style: 'os',
                    selector: 'td:first-child'
                },
                "ordering": false,//全局禁用排序
                "serverSide": true,
                "sAjaxSource": "/Manage/InvoiceList",//"@Url.Action('Reliefs','Manage')",
                "fnServerData": function (sSource, aoData, fnCallback) {
                    aoData.push({ "name": "strname", "value": "11212" });
                    $.ajax({
                        "dataType": 'json',
                        "type": "POST",
                        "url": sSource,
                        "data": aoData,
                        "success": fnCallback
                    });
                },
                "aoColumns": [
                    { "mDataProp": "CarCode", "width": "50" },
                    { "mDataProp": "InTime", "width": "400" },
                    { "mDataProp": "StartTime", "width": "200" },
                    { "mDataProp": "EndTime", "width": "100" },
                    { "mDataProp": "OperatorID", "width": "100" },
                    { "mDataProp": "OperationDate", "width": "100" },
                    { "mDataProp": "RecordID", "width": "100" }
                ],
            });
        },
    };
    $(function () {
        $.invoices.initData();
    });
})(jQuery);