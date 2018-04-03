def swap_string_for_array_negative_values(arr):
    for i in range(len(arr)):
        if arr[i]<0:
            arr[i]="Gorfus MacGregor"
    print arr

swap_string_for_array_negative_values([-2,5,6,4,-10,20,-3])
        