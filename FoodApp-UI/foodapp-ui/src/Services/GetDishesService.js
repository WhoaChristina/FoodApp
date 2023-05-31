const GetRestaurants = async (id) => 
{
    let url ='http://localhost:5090/api/GetDishes/' + id;
    return await fetch(url).then(resp => resp.json())
}
export default GetRestaurants