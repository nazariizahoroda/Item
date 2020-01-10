import React, { Component } from 'react';
import './Item.css';


export class ItemStatistic extends Component {
    static displayName = ItemStatistic.name;

    constructor(props) {
        super(props);
        this.state = {
            items: [], loading: true, pageInfo: null
        };
        fetch('api/Item/GetItemStatistic')
            .then(response => response.json())
            .then(data => {
                console.log(data);
                this.setState({ items: data.itemStatistic, loading: false, pageInfo: data.pageInfo });
            });
    }

    

    static renderForecastsTable(items) {
        return (
            
            <table className='table table-striped' id = "statistic">
                <thead>
                    <tr>
                        <th>Item type</th>
                        <th>Count</th>
                    </tr>
                </thead>
                <tbody>
                    {items.map(item =>
                        <tr key={item.type}>
                            <td>{item.type}</td>
                            <td>{item.count}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : ItemStatistic.renderForecastsTable(this.state.items);

        return (
            
            <div class = "item">
                <h1>Statistic</h1>
                {contents}
            </div>

        );
    }
}