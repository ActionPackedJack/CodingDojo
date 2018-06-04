function bst() {
    this.root = null;
    function node(val) {
        this.value = val;
        this.left = null;
        this.right = null;
    }
    this.insert = function (val) {
        if (this.root === null) {
            this.root = new node(val);
            return;
        }
       // console.log ("YES")
        current = this.root;
        //console.log (current);
        while (true) {
            if (val > current.value) {
                if (current.right) {
                    //console.log("moving right");
                    current = current.right;
                }
                else {
                    //console.log ("adding right");
                    current.right = new node(val);
                    return;
                }
            }
            if (val < current.value) {
                if (current.left) {
                    //console.log("moving left");
                    current=current.left;
                }
                else {
                    console.log ("adding left");
                    current.left = new node(val);
                }   
            }
            return this;
        }
    }
}

var tree = new bst();
tree.insert(12);
tree.insert(17);
tree.insert(7);
console.log(tree);