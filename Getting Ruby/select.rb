a = [1,2,4,5,6,7,8,8,9,]

a.each do |s|
  @selected = a.select{ s > 8 }
end

puts @selected
