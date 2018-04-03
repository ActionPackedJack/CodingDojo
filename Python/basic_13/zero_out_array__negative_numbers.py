def zero_out_array__negative_numbers(arr):
    for i in range(len(arr)):
        if arr[i]<0:
            arr[i]=0
    print arr

zero_out_array__negative_numbers([20,2,57,-5,12,-3])