let teste = "73.801-190".replace(/[.-]/g,"")
console.log(teste);

let help ;





const { exec } = require('node:child_process');
exec('clear')
const tetra = (a)=>{
    console.log(a)
    // return a == undefined?  "ude" : "undeffined a"
    // console.log()
}

// console.log(tetra());
// console.log(help == undefined? false: true )


const removeAccents = str =>
    str.normalize('NFD').replace(/[\u0300-\u036f]/g, '');
  
  removeAccents('Antoine de Saint-Exupéry'); // 'Antoine de Saint-Exupery'
console.log(removeAccents('Antoine Japão'));

// esssa parte é para tratar e buscar usando comparação, a natureza jurica do cnpj

// const axios = require('axios')
// const Fuse = require('fuse.js')

// // axios.get('https://api.cnpjs.dev/v1/00394684000153').then((response) =>{
//   axios.get('https://api.cnpjs.dev/v1/37628401000109').then((response) =>{
//   let {data} = response
//   let {endereco, natureza_juridica,razao_social} = data
//   let {uf} = endereco
//   console.log({uf,natureza_juridica, razao_social});
// })

// let list= ["Old Man's War", "The Lock Artist",'Municipio']
// const options = {
//   includeScore: true,
//   minMatchCharLength: 3
// }

// const fuse = new Fuse(list,options)

// const result = fuse.search('ti')
// console.log(result);

// const reg = /\d{3}/g;
// const str = "Java323Scr995ip4894545t";
// const newStr = str.replace(reg, "");
// console.log(newStr);
const word = "freecodecamp";

const capitalized = word.charAt(0).toUpperCase() + word.slice(1);
  