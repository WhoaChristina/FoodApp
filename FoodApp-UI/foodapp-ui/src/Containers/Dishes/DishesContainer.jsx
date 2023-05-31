import { useState, useEffect } from "react";
import { useLocation } from "react-router-dom";
import GetDishesService from "../../Services/GetDishesService"
import DishesComponent from "../../Components/Dishes/DishesComponent";

const DishesContainer = (props) =>
{
    const [dishes, setDishes] = useState();
    const loc = useLocation();
    const id = loc.state.id;
    const name = loc.state.name

    const getDishes = async () =>
    {
        const res = await GetDishesService(id);
        setDishes(res);
    }

    useEffect(() => {
        getDishes();
    },[]);
    
    if(dishes !== undefined)
    {
        return (<>
        <DishesComponent list ={dishes} name ={name} />
        </>)
    }

}
export default DishesContainer;