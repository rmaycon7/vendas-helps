// Requiring the module 
const reader = require('xlsx') 

// Reading our test file 
const file = reader.readFile('./Shopee_mass_upload_teste.xlsx') 

let data = [] 

const sheets = file.SheetNames 

console.log(sheets);
let columns = file.Sheets['Modelo']
let columnsHelp = reader.utils.sheet_to_json(columns);

for (let i in columnsHelp[1]){
    // console.log(columnsHelp[i]);
    console.log(i);
}
console.log(columnsHelp.length);
// console.log(reader.utils.sheet_to_json(columns));

// Requiring module 
// const reader = require('xlsx') 

// // Reading our test file 
// const file = reader.readFile('./test.xlsx') 

// // Sample data set 
// let student_data = [{ 
// 	Student:'Nikhil', 
// 	Age:22, 
// 	Branch:'ISE', 
// 	Marks: 70 
// }, 
// { 
// 	Student:'Amitha', 
// 	Age:21, 
// 	Branch:'EC', 
// 	Marks:80 
// }] 

// const ws = reader.utils.json_to_sheet(student_data) 

// reader.utils.book_append_sheet(file,ws,"Sheet3") 

// // Writing to our file 
// reader.writeFile(file,'./test.xlsx') 







// for(let i = 0; i < sheets.length; i++) 
// { 
// const temp = reader.utils.sheet_to_json( 
// 		file.Sheets[file.SheetNames[i]]) 
// temp.forEach((res) => { 
// 	data.push(res) 
// }) 
// } 

// // Printing data 
// console.log(data)
