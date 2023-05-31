import { NavLink } from "react-router-dom";
import HTCRestaurantCard from "../Cards/RestaurantCards/HTCRestaurantCard";
import HTRestaurantCard from "../Cards/RestaurantCards/HTRestaurantCard"
import RestaurantCard from "../Cards/RestaurantCards/RestaurantCard"
import './RestaurantComponent.css'

const RestaurantComponent = ({list}) =>
{
    let restaurantList = list.map(item =>
        {
            if (item.haveVisited == true) 
            {
                if(item.comment == null)
                {
                    return(<> 
                    <HTRestaurantCard item = {item} />
                    </>) 
                }
                else
                {
                    return(<>
                    <HTCRestaurantCard item = {item} />
                    </>) 
                }
  
            }
            else
            {
                return(<>
                    <RestaurantCard item = {item} />
                </>)   
            }
        })
        return(<>
        <div className="wrapper">
            {restaurantList}
        </div>
        </>)

}
export default RestaurantComponent;

/*
                        <div>
                            <h3>{item.name}, {item.rating} / 10</h3>     
                            <NavLink to={'/Dishes'} state ={{id : item.restaurantId, name : item.name}}><button>Rätter</button></NavLink>
                        </div>*/