app.service('orderService', orderService);
function orderService() {
    this.dishList = []
    
    this.addDish = function (dish) {
        var item = $.extend({}, dish);
        this.dishList.push(item)
    }

    this.cleanAll = function () {
        this.dishList.length = 0;
    }
}
