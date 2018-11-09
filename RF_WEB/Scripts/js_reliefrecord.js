(function ($) {
    $.relieflist = {
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
                "sAjaxSource": "/Manage/Reliefs",//"@Url.Action('Reliefs','Manage')",
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
                    { "mDataProp": "RecordID", "width": "50" },
                    { "mDataProp": "CarCode", "width": "400" },
                    { "mDataProp": "RecordID", "width": "200" },
                    { "mDataProp": "CarCode", "width": "100" },
                    { "mDataProp": "CarCode", "width": "100" },
                    { "mDataProp": "RecordID", "width": "100" },
                    { "mDataProp": "CarCode", "width": "100" },
                    { "mDataProp": "RecordID", "width": "100" },
                    { "mDataProp": "CarCode", "width": "100" }
                ],
                "oLanguage": { // 国际化配置
                    "sProcessing": "正在获取数据，请稍后...",
                    "sLengthMenu": "显示 _MENU_ 条",
                    "sZeroRecords": "没有找到数据",
                    "sInfo": "从 _START_ 到  _END_ 条记录 总记录数为 _TOTAL_ 条",
                    "sInfoEmpty": "记录数为0",
                    "sInfoFiltered": "(全部记录数 _MAX_ 条)",
                    "sInfoPostFix": "",
                    "sSearch": "查询",
                    "sUrl": "",
                    "oPaginate": {
                        "sFirst": "第一页",
                        "sPrevious": "上一页",
                        "sNext": "下一页",
                        "sLast": "最后一页"
                    }
                },
            });
        },
    };
    $(function () {
        $.relieflist.initData();
    });
})(jQuery);