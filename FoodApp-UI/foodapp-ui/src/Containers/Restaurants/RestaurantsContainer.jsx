import { useState, useEffect } from "react";
import GetRestaurants from '../../Services/GetRestaurantsService'
import { useLocation } from "react-router-dom";
import RestaurantComponent from "../../Components/Restaurants/RestaurantComponent";

const RestaurantsContainer = (props) =>
{
    const [restaurants, setRestaurants] = useState([]);
    const loc = useLocation();
    const cat = loc.state.category;
    
    const get = async () =>
    {
        const res = await GetRestaurants(cat);
        setRestaurants(res);
    }
    
    useEffect(() => {
        get();
    }, [])
    if(restaurants !== undefined)
    {
        return(<>
            <RestaurantComponent list = {restaurants} />
            </>)
    }
}

export default RestaurantsContainer;