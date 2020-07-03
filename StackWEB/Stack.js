// Trình xây dựng cho Stack
function Stack() {
  this.list = [];

  // Đẩy một phần tử vào ngăn xếp
  this.push = function (e) {
    this.list.push(e);
  }
  // Bật đỉnh từ ngăn xếp
  this.pop = function () {
    return this.list.pop();
  }

  // Lấy đỉnh từ ngăn xếp
  this.peek = function () {
    return this.list[this.getSize() - 1];
  }

 // Trả về kích thước ngăn xếp
  this.getSize = function () {
    return this.list.length;
  }

  // Trả về true nếu stack trống
  this.isEmpty = function () {
    return this.list.length == 0;
  }
}//