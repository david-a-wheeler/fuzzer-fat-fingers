// a "random" 2-D array 
var a = [[2, 12, 10, 4], [18, 11, 9, 3], [14, 15, 7, 17], [6, 19, 8, 13], [1, 20, 16, 5]];
 
outer_loop:
for (var i in a) {
    document.write("row " + i);
    for (var j in a[i]) {
        document.write(" " + a[i][j]);
        if (a[i][j] == 20) 
            break outer_loop;
    }
}
document.write("done");
