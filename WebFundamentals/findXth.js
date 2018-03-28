function findXth(arr, xth){
  var newArr=[];
  function maxPush(dumbArray){
    var max= dumbArray[0];
    var maxplace=0;
    for(var i=1;i<dumbArray.length;i++){
      console.log(dumbArray[i]);
      if(dumbArray[i]>max){
        max=dumbArray[i];
        maxplace=i;
      }
    }
      console.log("max:",max,dumbArray[maxplace])
      newArr.push(max);
      console.log("new:",newArr);
      console.log("original:", dumbArray)
      var temp=dumbArray[maxplace];
      dumbArray[maxplace]=dumbArray[dumbArray.length-1];
      dumbArray.pop();
    }
  }
  for(var j=0;j<arr.length;j++){
    maxPush(arr);
  }
  console.log(newArr);
  return(newArr[xth-1]);
}

findXth([15,12,7,23,900,-2.3,0],4)