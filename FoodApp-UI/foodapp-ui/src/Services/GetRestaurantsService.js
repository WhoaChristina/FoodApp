const GetRestaurants = async (cat) => {

    let url ='http://localhost:5090/api/GetRestaurants/' + cat;
    return await fetch(url).then(resp => resp.json())
}
export default GetRestaurants