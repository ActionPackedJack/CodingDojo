function bubblesort(arr){
  var temp =0;
  for(var i = 1; i <arr.length; i++){
    if(arr[i]<arr[i-1]){
      temp=arr[i];
      arr[i]=arr[i-1];
      arr[i-1]=temp;
      i=1;
    }
  }
  return arr;
}
(bubblesort([1,5,7,2,9,10,12,17]))