function binarysearch(arr, target, leftbehind=0){
    if(arr.length<2){
      if(arr[0]===target){
        return true;
      }
      else{
        return false;
      }
    }
    var splitpoint=Math.ceil(arr.length/2);
    if (arr[splitpoint]===target){
        return (splitpoint+leftbehind);
    }
    if(arr[splitpoint]>target){
        newarray= arr.slice(0,splitpoint);
        return binarysearch(newarray,target,leftbehind);
    }
    if(arr[splitpoint]<target){
        newarray= arr.slice(splitpoint, arr.length);
        leftbehind+=arr.length-newarray.length;
        return binarysearch(newarray,target, leftbehind);
    }
}
binarysearch([1, 3, 8, 10, 12, 15, 17, 20, 22, 34, 38, 40, 50, 52, 78, 87, 90, 91, 92, 94], 15)

