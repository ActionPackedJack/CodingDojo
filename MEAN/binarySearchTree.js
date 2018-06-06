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
        var current = this.root;
        //console.log (current);
        while (current) {
            if (val > current.value) {
                if (current.right) {
                    console.log(current.value);
                    console.log("moving right");
                    current = current.right;
                }
                else {
                    console.log ("adding " + val  + " to the right");
                    current.right = new node(val);
                    return;
                }
            }
            if (val < current.value) {
                if (current.left) {
                    console.log("moving left from  " +current.value + " to " +current.left.value);
                    current=current.left;
                }
                else {
                    console.log ("adding" + val + "to the left of " + current.value);
                    current.left = new node(val);
                }   
            }
            return ;
        }
    }
    this.preorder= function (current=this.root){
        
        console.log(current.value);
            if(current.left){
                console.log("moving left");
                this.preorder(current.left);
            }
            if(current.right){
                console.log("moving right");
                this.preorder(current.right);
            }
            return;            
        }
    }


var tree = new bst();
tree.insert(40);
tree.insert(20);
tree.insert(25);
tree.insert(50);
// console.log(tree);
// tree.preorder();