const GetRandom = async () => {

    let url ='http://localhost:5090/api/GetRandom'
    return await fetch(url).then(resp => resp.json())
}
export default GetRandom