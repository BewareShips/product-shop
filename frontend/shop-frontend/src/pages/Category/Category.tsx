import React from 'react';
import { useParams } from 'react-router-dom';

const Category: React.FC = () => {
  const { id } = useParams<{ id: string }>();

  return (
    <div>
      <h1>Category Page for Category ID: {id}</h1>
    </div>
  );
};

export default Category;