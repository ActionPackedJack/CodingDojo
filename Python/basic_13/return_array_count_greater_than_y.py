def return_array_count_greater_than_y(arr,y):
    result=0
    for i in range(len(arr)):
        if arr[i]>y:
            result+=1
            print arr[i]
    print result

return_array_count_greater_than_y([1,2,3,4,5,6,7],3)